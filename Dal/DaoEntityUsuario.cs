using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DaoEntityUsuario : IDao<Usuario>
    {
        public void Borrar(long id)
        {
            using(var db = new MF0966Context())
            {
                db.Usuarios.Remove(db.Usuarios.Find(id));
                db.SaveChanges();
            }
        }

        public Usuario Insertar(Usuario usuario)
        {
            using(var db = new MF0966Context())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return usuario;
            }
        }

        public Usuario Modificar(Usuario usuario)
        {
            using(var db = new MF0966Context())
            {
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return usuario;
            }
        }

        public Usuario ObtenerPorId(long id)
        {
            using(var db = new MF0966Context())
            {
                return db.Usuarios.Find(id);
            }
        }

        public IEnumerable<Usuario> ObtenerTodos()
        {
            using(var db = new MF0966Context())
            {
                return db.Usuarios.ToList();
            }
        }
    }
}
