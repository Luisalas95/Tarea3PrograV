﻿//using CapaDatos;
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
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
           

        }

        protected void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {

           

           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string ClaveNueva = "";
                string Clave = "";
                string ClaveEncriptada = "";

                string IDs = txt_ID.Text;
                string Nombre = txt_Nombre.Text;
                string Apellidos = txt_Apellidos.Text;

                ClaseUsuario claseUsuario = new ClaseUsuario();
                Encriptar encriptar = new Encriptar();
                GeneraClave generaClave = new GeneraClave();
               
                ClaveNueva = GeneraClave.ClaveGenerada(Clave);
                
                lblClave.Text = ClaveNueva;

                Response.Write("<script>alert('Contraseña: " + ClaveNueva + "')</script>");
                int ID = Int32.Parse(IDs);
                

                ClaveEncriptada = encriptar.GetSHA256(ClaveNueva);


                claseUsuario.InsertarUsuario(1, ID, Nombre, Apellidos, ClaveEncriptada);

              //  Response.Redirect("Login.aspx");
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