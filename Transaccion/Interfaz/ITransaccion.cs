using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transaccion.Interfaz
{
    public interface ITransaccion
    {
        List<tbl_user> GetUser();
        
        void InsertUser(tbl_user nuevoAlumno);

        void UpdateUser(tbl_user actualizarAlumno);

        void DeleteUser(tbl_user eliminarUser);

        bool login(string usuario, string password);
    }
}
