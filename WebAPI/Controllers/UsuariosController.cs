using Dal;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        private static readonly IDao<Usuario> dao = new DaoEntityUsuario();
        // GET: api/Usuarios
        public IEnumerable<Usuario> Get()
        {
            return dao.ObtenerTodos();
        }

        // GET: api/Usuarios/5
        public Usuario Get(long id)
        {
            return dao.ObtenerPorId(id);
        }

        // POST: api/Usuarios
        public Usuario Post([FromBody]Usuario usuario)
        {
            return dao.Insertar(usuario);
        }

        // PUT: api/Usuarios/5
        public Usuario Put(long id, [FromBody] Usuario usuario)
        {
            return dao.Modificar(usuario);
        }

        // DELETE: api/Usuarios/5
        public void Delete(long id)
        {
            dao.Borrar(id);
        }
    }
}
