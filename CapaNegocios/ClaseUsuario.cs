using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using CapaDatos;

namespace CapaNegocio
{
    public class ClaseUsuario
    {
        //gd comentario prueba
        private tiusr6pl_Tarea3PrograVEntities1 entities1;

        //constructor
        public ClaseUsuario()
        {
            entities1 = new tiusr6pl_Tarea3PrograVEntities1();
        }
        public int InsertarUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities1.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities1.SaveChanges();
        }

        public int ValidarUsuario( int identificacion,  string contrasena)
        {
            entities1.Verificar( identificacion, contrasena);
            return entities1.SaveChanges();

        }

        public int EliminaUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities1.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities1.SaveChanges();
        }
    }
}
