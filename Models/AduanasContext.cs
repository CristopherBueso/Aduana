using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aduanas.Models
{
    public partial class AduanasContext : DbContext
    {
        public AduanasContext()
        {
        }

        public AduanasContext(DbContextOptions<AduanasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agencia> Agencias { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost; database=Aduanas; integrated security = true; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>(entity =>
            {
                entity.HasKey(e => e.IdAgencia)
                    .HasName("PK__agencias__2F17429241844231");

                entity.ToTable("agencias");

                entity.Property(e => e.IdAgencia).HasColumnName("idAgencia");

                entity.Property(e => e.Direccion)
                    .HasColumnType("text")
                    .HasColumnName("direccion");

                entity.Property(e => e.NombreAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombreAgencia");

                entity.Property(e => e.Pais)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__empleado__5295297CF37A231A");

                entity.ToTable("empleados");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Clave)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.IdAgencia).HasColumnName("idAgencia");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK__empleados__idAge__2A4B4B5E");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK__empleados__idPer__29572725");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__empleados__idRol__2B3F6F97");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__personas__A478814175BD1575");

                entity.ToTable("personas");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.PaisNaturalizacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paisNaturalizacion");

                entity.Property(e => e.PaisOrigen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paisOrigen");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__roles__3C872F7637E27B5F");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
