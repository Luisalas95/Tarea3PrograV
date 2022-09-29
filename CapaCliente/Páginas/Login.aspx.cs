using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace CapaCliente
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_IniciarSesion_Click(object sender, EventArgs e)
        {   

            string usuario = txt_Usuario.Text;
            int result = Int32.Parse(usuario);
            string clave= txt_Clave.Text;
            Encriptar encriptar = new Encriptar();
            string clavedes =encriptar.GetSHA256(clave);

            ClaseUsuario CU = new ClaseUsuario();
            CU.ValidarUsuario(result,clavedes);
            Response.Redirect("CambiarCredenciales.aspx");
        }


        protected void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txt_Clave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}