using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API.REST.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<roles>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.usuarios)
                .WithOptional(e => e.roles)
                .HasForeignKey(e => e.rol_id);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.correo_electronico)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.contrasena)
                .IsUnicode(false);
        }
    }
}
