using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using Transaccion.Interfaz;

namespace WcfColegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        ITransaccion transaccion;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Service1(ITransaccion transaccion)
        {
            this.transaccion = transaccion;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<tbl_user> GetUser()
        {
            List<tbl_user> user = transaccion.GetUser();
            return user;
        }

        public void InsertUser(tbl_user nuevoAlumno)
        {
            transaccion.InsertUser(nuevoAlumno);
        }

        public void UpdateUser(tbl_user actualizarAlumno)
        {
            transaccion.UpdateUser(actualizarAlumno);
        }

        public void DeleteUser(tbl_user eliminarAlumno)
        {
            transaccion.DeleteUser(eliminarAlumno);
        }

        public bool login(string usuario, string password)
        {
            return transaccion.login(usuario, password);
        }
    }
}
