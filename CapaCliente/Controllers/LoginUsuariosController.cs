using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CapaDatos;

namespace CapaCliente.Controllers
{
    public class LoginUsuariosController : ApiController
    {
        private tiusr6pl_Tarea3PrograVEntities2 db = new tiusr6pl_Tarea3PrograVEntities2();

        // GET: api/LoginUsuarios
        public IQueryable<LoginUsuario> GetLoginUsuarios()
        {
            return db.LoginUsuarios;
        }

        // GET: api/LoginUsuarios/5
        [ResponseType(typeof(LoginUsuario))]
        public async Task<IHttpActionResult> GetLoginUsuario(int id)
        {
            LoginUsuario loginUsuario = await db.LoginUsuarios.FindAsync(id);
            if (loginUsuario == null)
            {
                return BadRequest("Usuario y/o contraseña incorrectos");
            }

            return Ok(loginUsuario);
        }

        // PUT: api/LoginUsuarios/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLoginUsuario(int id, LoginUsuario loginUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != loginUsuario.Identificacion)
            {
                return BadRequest();
            }

            db.Entry(loginUsuario).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginUsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LoginUsuarios
        [ResponseType(typeof(LoginUsuario))]
        public async Task<IHttpActionResult> PostLoginUsuario(LoginUsuario loginUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LoginUsuarios.Add(loginUsuario);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoginUsuarioExists(loginUsuario.Identificacion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = loginUsuario.Identificacion }, loginUsuario);
        }

        // DELETE: api/LoginUsuarios/5
        [ResponseType(typeof(LoginUsuario))]
        public async Task<IHttpActionResult> DeleteLoginUsuario(int id)
        {
            LoginUsuario loginUsuario = await db.LoginUsuarios.FindAsync(id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            db.LoginUsuarios.Remove(loginUsuario);
            await db.SaveChangesAsync();

            return Ok(loginUsuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoginUsuarioExists(int id)
        {
            return db.LoginUsuarios.Count(e => e.Identificacion == id) > 0;
        }
    }
}