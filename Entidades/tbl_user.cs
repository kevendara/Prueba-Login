namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        public int id { get; set; }

        [StringLength(50)]
        public string contraseña { get; set; }

        [StringLength(50)]
        public string nombreCuenta { get; set; }

        [StringLength(50)]
        public string nombrePersona { get; set; }
    }
}
