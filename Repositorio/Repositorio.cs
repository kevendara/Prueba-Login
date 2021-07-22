using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositorio
{
    public class Repositorio<TObject> : IRepositorio<TObject> where TObject : class
    {
        public Repositorio(DbContext context)
        {
            Context = context;
        }

        protected DbContext Context = null;

        protected DbSet<TObject> DbSet
        {
            get
            {
                return Context.Set<TObject>();
            }
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }

        public virtual IQueryable<TObject> All()
        {
            return DbSet.AsQueryable();
        }

        public virtual IQueryable<TObject> Filter(Expression<Func<TObject, bool>> predicate)
        {
            IQueryable<TObject> result = DbSet.Where(predicate).AsQueryable<TObject>();
            return result;
        }

        public virtual IQueryable<TObject> Filter(Expression<Func<TObject, bool>> filter, out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            var _resetSet = filter != null ? DbSet.Where(filter).AsQueryable() : DbSet.AsQueryable();
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public bool Contains(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.Count(predicate) > 0;
        }

        public virtual TObject Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public virtual TObject Find(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public virtual int Create(TObject TObject)
        {
            var entry = DbSet.Add(TObject);
            return Context.SaveChanges();
        }
        public virtual int Create(List<TObject> TObject)
        {
            foreach (var item in TObject)
            {
                DbSet.Add(item);

            }
            //var newEntry = DbSet.Add(TObject);
            return Context.SaveChanges();
        }

        //GUARDADO MASIVO CON EL METODO BULLCOPY
        public virtual int CreateMasivo(List<TObject> TObject)
        {
            //this.Context.BulkInsert(TObject);
            return Context.SaveChanges();
        }

        public virtual int Count
        {
            get
            {
                return DbSet.Count();
            }
        }
        public virtual int Delete(TObject TObject)
        {
            DbSet.Remove(TObject);
            return Context.SaveChanges();
        }
        public virtual int Update(TObject TObject)
        {
            var entry = Context.Entry(TObject);
            DbSet.Attach(TObject);
            entry.State = EntityState.Modified;
            return Context.SaveChanges();
        }
        public virtual int Update(List<TObject> TObject)
        {
            foreach (var item in TObject)
            {
                var entry = Context.Entry(item);
                DbSet.Attach(item);
                entry.State = EntityState.Modified;
            }

            return Context.SaveChanges();
        }
        public virtual int Delete(Expression<Func<TObject, bool>> predicate)
        {
            var objects = Filter(predicate);
            foreach (var obj in objects)
                DbSet.Remove(obj);
            return Context.SaveChanges();
        }
        public virtual long Max(Func<TObject, long> predicate)
        {
            return DbSet.Max(predicate);

        }
        /*Eliminación masiva de una tabla*/
        public virtual int Delete(List<TObject> lista)
        {
            foreach (var obj in lista)
                DbSet.Remove(obj);
            return Context.SaveChanges();
        }
        public IQueryable<TObject> SqlQuery(string sql, Dictionary<string, string> parametros, int timeout)
        {
            this.Context.Database.CommandTimeout = timeout;
            Object[] param = new Object[parametros.Count];
            int pos = -1;
            foreach (KeyValuePair<string, string> item in parametros)
            {
                pos++;
                param[pos] = new System.Data.SqlClient.SqlParameter(item.Key, item.Value);

            }

            return DbSet.SqlQuery(sql, param).AsQueryable();
        }
        //public int Max(Expression<Func<TObject, bool>> predicate)
        //{
        //    return DbSet.Max(predicate);

        //}

    }
}
