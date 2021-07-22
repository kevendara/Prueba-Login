using Entidades;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Implementacion
{
    public class tbl_UserRepositorio : Repositorio<tbl_user>, Itbl_UserRepositorio
    {
        public tbl_UserRepositorio(Model1 contexto)
            : base(contexto)
        {
        }

        public void Inicializar()
        {
            this.Context = new Model1();
        }
    }
}
