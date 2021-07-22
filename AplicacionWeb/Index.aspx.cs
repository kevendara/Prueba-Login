
using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Index : System.Web.UI.Page
    {

        ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridUser();
        }


        protected void GridUser()
        {
            store_Usuarios.DataSource = servicio.GetUser();
            store_Usuarios.DataBind();
        }


        protected void InsertUsuarios()
        {
            //int iduser = this.idUsuario.Text;
            string contraseña = this.contrasenias.Text;
            string nombreCuenta = this.nombrePersonas.Text;
            string nombrePerson = this.nombresCuentas.Text;

            ServiceReference1.tbl_user usuario = new ServiceReference1.tbl_user
            {
                contraseña = contraseña,
                nombreCuenta = nombreCuenta,
                nombrePersona = nombrePerson
            };

            servicio.InsertUser(usuario);

        }

        [DirectMethod]
        protected void InsertarUser(Object sender, EventArgs e)
        {
            InsertUsuarios();
            gridPanelUsuarios.Reload();
        }

        protected void UpdateUsuario()
        {
            int iduser = int.Parse(this.idUsuarios.Text);
            string contraseña = contrasenias.Text;
            string nombreCuenta = nombrePersonas.Text;
            string nombrePerson = nombresCuentas.Text;

            ServiceReference1.tbl_user usuario = new ServiceReference1.tbl_user
            {
                id = iduser,
                contraseña = contraseña,
                nombreCuenta = nombreCuenta,
                nombrePersona = nombrePerson
            };
            servicio.UpdateUser(usuario);
        }

        [DirectMethod]
        protected void ActualizarUsuario(Object sender, EventArgs e)
        {
            UpdateUsuario();
            gridPanelUsuarios.Reload();
        }


        protected void EliminarUsuario()
        {
            int iduser = int.Parse(this.idUsuarios.Text);
            string contraseña = contrasenias.Text;
            string nombreCuenta = nombrePersonas.Text;
            string nombrePerson = nombresCuentas.Text;

            ServiceReference1.tbl_user usuario = new ServiceReference1.tbl_user
            {
                id = iduser,
                contraseña = contraseña,
                nombreCuenta = nombreCuenta,
                nombrePersona = nombrePerson
            };
            servicio.DeleteUser(usuario);
        }

        [DirectMethod]
        protected void EliminarUsuario(object sender, EventArgs e)
        {
            EliminarUsuario();
            gridPanelUsuarios.Reload();
        }


        [DirectMethod]
        protected void LimpiarCampos(object sender, EventArgs e)
        {
            formPanelUsuarios.Reset();
        }
        
    }
}