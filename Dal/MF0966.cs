using Entidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dal
{
    public partial class MF0966Context : DbContext
    {
        public MF0966Context()
            : base("name=MF0966")
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
