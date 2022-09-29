//using CapaDatos;
//using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaCliente.Páginas
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {

          string Clave="";
            //Encriptar encriptar = new Encriptar();
           // GeneraClave generaClave = new GeneraClave();
         //   ClaseUsuario claseUsuario = new ClaseUsuario();
         //   claseUsuario.ClaveGenerada(Clave);
            lblClave.Text = Clave;

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}