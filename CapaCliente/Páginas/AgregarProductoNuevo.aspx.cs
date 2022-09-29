using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocios;
using Swashbuckle.Swagger;

namespace CapaCliente.Páginas
{
    public partial class AgregarProductoNuevo : System.Web.UI.Page
    {
        private Productos ProductoNegocios = new Productos();
        private Producto Producto1 = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_GuardarProduc_Click(object sender, EventArgs e)
        {
            try
            {
                Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                Producto1.NombreProducto = txt_Nomb.Value;
                Producto1.Existencias = float.Parse(txt_existencia.Value);
                Producto1.BodegaUbicacion = txt_UbicacionBodega.Value;
                ProductoNegocios.CrudProductos(1, Producto1);

            }
            catch (Exception ex)
            {
                
                Response.Write("<script> alert('Error al guardar los datos, intente de nuevo')  </script> ");
            }



        }
    }
}