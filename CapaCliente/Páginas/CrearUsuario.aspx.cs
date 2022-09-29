//using CapaDatos;
using CapaNegocio;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Http.Results;

namespace CapaCliente.Páginas
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        string ClaveNueva = "";
        string Clave = "";
        string ClaveEncriptada = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaseUsuario claseUsuario = new ClaseUsuario();
            Encriptar encriptar = new Encriptar();
            GeneraClave generaClave = new GeneraClave();
            ClaveEncriptada = encriptar.GetSHA256(ClaveNueva);
            ClaveNueva = GeneraClave.ClaveGenerada(Clave);
            lblClave.Text = ClaveNueva;
           

        }

        protected void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {

           

           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string IDs = txt_ID.Text;
                string Nombre = txt_Nombre.Text;
                string Apellidos = txt_Apellidos.Text;


                int ID = Int32.Parse(IDs);
                string Clave = "";

                ClaseUsuario claseUsuario = new ClaseUsuario();


                claseUsuario.InsertarUsuario(1, ID, Nombre, Apellidos, ClaveEncriptada);

                Response.Redirect("AdministracionProductos.aspx");
            }
            catch
            {
                Response.Write("<script>alert('Error al guardar los datos, intente de nuevo')</script>");
            }
        }

        protected void txt_Apellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}