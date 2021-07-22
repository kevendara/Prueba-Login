using Entidades;
using Repositorio.Interfaz;
using Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Implementacion
{
    public class Acceso : IAcceso
    {

        Itbl_UserRepositorio userRepositorio;

        public Acceso(
            Itbl_UserRepositorio userRepositorio)
        {
            this.userRepositorio = userRepositorio;
        }


        public void Inicializar()
        {
            userRepositorio.Inicializar();
        }

        
        //IMPLEMENTACION ESTUDIANTE
        /*Listar todos los alumnos*/
        public List<tbl_user> GetUser()
        {
            List<tbl_user> users = this.userRepositorio.All().ToList();

            return (from a in users
                    select new tbl_user
                    {
                        id=a.id,
                        contraseña=a.contraseña,
                        nombreCuenta=a.nombreCuenta,
                        nombrePersona=a.nombrePersona
                    }).ToList();
        }

        /*Crear un alumno*/
        public void InsertUser(tbl_user nuevoAlumno)
        {
            this.userRepositorio.Create(nuevoAlumno);
        }

        /*Actualizar un alumno*/
        public void UpdateUser(tbl_user actualizarUser)
        {
            tbl_user encontrarEstudiante = this.userRepositorio.Find(
                t => t.id.Equals(actualizarUser.id));
            encontrarEstudiante.contraseña = actualizarUser.contraseña;
            encontrarEstudiante.nombreCuenta = actualizarUser.nombreCuenta;
            encontrarEstudiante.nombrePersona = actualizarUser.nombrePersona;
            this.userRepositorio.Update(encontrarEstudiante);
        }


        public void DeleteUser(tbl_user deleteUser)
        {
            tbl_user encontrarEstudiante = this.userRepositorio.Find(
                t => t.id.Equals(deleteUser.id));
            this.userRepositorio.Delete(encontrarEstudiante);
        }
        public bool login(string usuario, string password)
        {

            tbl_user encontrarEstudiante = this.userRepositorio.Find(
                    t => t.nombreCuenta == usuario && t.contraseña == password);

            if (encontrarEstudiante != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
