using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CapaCliente.Páginas
{
    public partial class MantenimientoProductos : System.Web.UI.Page
    {
        private Productos ProductoNegocios = new Productos();
        private Producto Producto1 = new Producto();
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string CodigoProducto = Request.QueryString["CodigoP"];
                string NombreProducto = Request.QueryString["NomProduct"];
                string Existencia = Request.QueryString["Existenc"];
                string Bodega = Request.QueryString["Bodeg"];
                int CodigoProductoEntero = int.Parse(Request.QueryString["CodigoP"]);
                txt_codigoproduct.Value = CodigoProducto;
                txt_Nomb.Value = NombreProducto;
                txt_existencia.Value = Existencia;
                txt_UbicacionBodega.Value = Bodega;
            }


        }

        protected void Btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto Producto2 = new Producto();
                
                Producto2.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                Producto2.NombreProducto = txt_Nomb.Value;
                Producto2.Existencias = float.Parse(txt_existencia.Value);
                Producto2.BodegaUbicacion = txt_UbicacionBodega.Value;
                ProductoNegocios.CrudProductos(2,Producto2);
                Response.Write("<script> alert('Se actualizo de forma correcta por favor regrese a la pantalla anterior')  </script> ");
                 
                //  Response.Redirect("AgregarProductoNuevo.aspx");

            }
            catch (Exception)
            {

                Response.Write("<script> alert('Error al actualizar')  </script> ");

            }


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
              
                Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                Producto1.NombreProducto = "";
                Producto1.Existencias = 0;
                Producto1.BodegaUbicacion = "";
                ProductoNegocios.CrudProductos(3, Producto1);
                Response.Write("<script> alert('Se elimino de forma correcta por favor regrese a la pantalla anterior')  </script> ");
                txt_codigoproduct.Value = "";
                txt_Nomb.Value = "";
                txt_existencia.Value = "";
                txt_UbicacionBodega.Value = "";




            }
            catch (Exception)
            {

                Response.Write("<script> alert('Error al eliminar')  </script> ");
            }

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductoNuevo.aspx");
        }
    }
}