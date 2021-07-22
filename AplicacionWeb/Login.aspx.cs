using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Login : System.Web.UI.Page
    {

        ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [DirectMethod]
        protected void btnLogin_Click(Object sender, EventArgs e)
        {
            string usuario = this.UserName.Text;
            string contraseña = this.Password.Text;
            if (servicio.login(usuario, contraseña))
            {
                Response.Redirect("Index.aspx", true);
            }
        }
    }
}