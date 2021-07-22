using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Servicio.Implementacion;
using Transaccion.Interfaz;

namespace Transaccion.Implementacion
{
    public class Transaccion: ITransaccion
    {
        public Acceso acceso;
        public Transaccion(Acceso acceso)
        {
            this.acceso = acceso;
        }


        public List<tbl_user> GetUser()
        {
            List<tbl_user>  user = acceso.GetUser();
            return user;
        }

        public void InsertUser(tbl_user nuevoAlumno)
        {
            acceso.InsertUser(nuevoAlumno);
        }

        public void UpdateUser(tbl_user actualizarAlumno)
        {
            acceso.UpdateUser(actualizarAlumno);
        }

        public void DeleteUser(tbl_user eliminarAlumno)
        {
            acceso.DeleteUser(eliminarAlumno);
        }

        public bool login(string usuario, string password)
        {
            return acceso.login(usuario, password);
        }
    }
}
