using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Http.Results;
using System.Web.Services.Description;
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
            try
            {
                string usuario = txt_Usuario.Text;
                int result = Int32.Parse(usuario);
                string clave = txt_Clave.Text;
                Encriptar encriptar = new Encriptar();//encripta las claves y las guarda en BD encriptadaas
                string clavedes = encriptar.GetSHA256(clave);

                ClaseUsuario CU = new ClaseUsuario();
                CU.ValidarUsuario(result, clavedes);
                Response.Redirect("AgregarProductoNuevo.aspx");
            }
            catch {
                Response.Write("<script>alert('Usuario y/o contraseña incorrectos')</script>");
            }
        }


        protected void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txt_Clave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}