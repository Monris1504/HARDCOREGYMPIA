using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HARDCOREGYM.Models.dbModels
{
    public partial class HARDCOREGYMContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public HARDCOREGYMContext()
        {
        }

        public HARDCOREGYMContext(DbContextOptions<HARDCOREGYMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carrito> Carritos { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<CompraDetalle> CompraDetalles { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.HasKey(e => new { e.Idusuario, e.Idproducto })
                    .HasName("PK_Carrito_1");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Carritos)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrito_Producto");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Carritos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrito_Usuario");
            });

            modelBuilder.Entity<CompraDetalle>(entity =>
            {
                entity.HasKey(e => new { e.Idcompra, e.Idproducto });

                entity.HasOne(d => d.IdcompraNavigation)
                    .WithMany(p => p.CompraDetalles)
                    .HasForeignKey(d => d.Idcompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompraDetalle_Compra");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.CompraDetalles)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompraDetalle_Producto");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.Idplan)
                    .HasName("PK_Plan_1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK_Producto_1");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
