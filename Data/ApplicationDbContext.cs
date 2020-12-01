using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tarea6_7.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {

        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Tesoros> Tesoros {get; set;}
        public DbSet<Coordenadas> Coordenadas {get; protected set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>(entityTypeBuilder => {
            entityTypeBuilder.ToTable("Usuarios");
            entityTypeBuilder.Property(i => i.UsuarioId).HasMaxLength(100).IsRequired();
            entityTypeBuilder.Property(i => i.Nombre).HasMaxLength(100);
            entityTypeBuilder.Property(i => i.Color).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }

    public class Usuario : IdentityUser
    {
        public Guid UsuarioId {get; set;}
        public string Nombre {get; set;}
        public string Color {get; set;}
    }

    public class Tesoros
    {
        public Guid UsuarioId {get; set;}
        public Guid Id {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public DateTime Fecha {get; set;}
        public float Peso {get; set;}
        public string Lugar {get; set;}
        public float Valor {get; set;}
        public Coordenadas Coordenadas {get; set;}
        public string UrlRef {get; set;}

    }

    public class  Coordenadas
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid UsuarioId {get; set;}
        public float Latitud {get; set;}
        public float Longitud {get; set;}

    }
}
