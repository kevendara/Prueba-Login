using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Entidades
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=I_Route")
        {
        }

        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_user>()
                .Property(e => e.contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.nombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.nombrePersona)
                .IsUnicode(false);
        }
    }
}
