using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Interfaz
{
    public interface IAcceso
    {
        void Inicializar();

        List<tbl_user> GetUser();

        void InsertUser(tbl_user  nuevoAlumno);

        void UpdateUser(tbl_user actualizarAlumno);

        void DeleteUser(tbl_user actualizarAlumno);


        bool login(string usuario, string password);
    }
}
