using System;
using System.Collections.Generic;
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


    }
}
