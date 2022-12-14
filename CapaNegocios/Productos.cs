using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Productos
    {
        private tiusr6pl_Tarea3PrograVEntities2 entities;

        public Productos()
        {
            entities = new tiusr6pl_Tarea3PrograVEntities2();
        }

        public void CrudProductos(int CodigoCrud, Producto objetoProducto) {
            try
            {
                entities.CRUDProducto(CodigoCrud, objetoProducto.CodigoProducto, objetoProducto.NombreProducto, objetoProducto.Existencias, objetoProducto.BodegaUbicacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public List<Object> ConsultaProductos() {
            var query = entities.Listar_Productos();
            return query.ToList<Object>();
        }

        public string ListaProductoCodigo(int codigoProducto)
        {
            string Lista="";
           var query = entities.ListaProductosCodigo(codigoProducto);
            foreach (var item in query)
            {
                Lista = item.NombreProducto + "/" + item.Existencias + "/" + item.BodegaUbicacion;

            }

            return Lista;
        }


    }
}
