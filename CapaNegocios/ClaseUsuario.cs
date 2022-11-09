using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CapaNegocio
{
    public class ClaseUsuario
    {
        [JsonProperty("Identificacion")]
        public long Identificacion { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("Contraseña")]
        public string Contraseña { get; set; }
        //gd comentario prueba
        private tiusr6pl_Tarea3PrograVEntities2 entities;

        //constructor
        public ClaseUsuario()
        {
            entities = new tiusr6pl_Tarea3PrograVEntities2();
        }
        public int InsertarUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities.SaveChanges();
        }

        public int ValidarUsuario(int identificacion, string contrasena)
        {
            entities.Verificar(identificacion, contrasena);
            return entities.SaveChanges();

        }

        public int EliminaUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities.SaveChanges();
        }
    }

    public partial class ClaseUsuario
    {
        public static ClaseUsuario FromJson(string json) => JsonConvert.DeserializeObject<ClaseUsuario>(json, CapaNegocio.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ClaseUsuario self) => JsonConvert.SerializeObject(self, CapaNegocio.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
