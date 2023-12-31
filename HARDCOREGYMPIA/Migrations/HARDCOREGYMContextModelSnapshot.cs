﻿// <auto-generated />
using System;
using HARDCOREGYMPIA.Models.dbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HARDCOREGYMPIA.Migrations
{
    [DbContext(typeof(HARDCOREGYMContext))]
    partial class HARDCOREGYMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("Idplan")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Idplan");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Carrito", b =>
                {
                    b.Property<int>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("IDUsuario");

                    b.Property<int>("Idproducto")
                        .HasColumnType("int")
                        .HasColumnName("IDProducto");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasKey("Idusuario", "Idproducto")
                        .HasName("PK_Carrito_1");

                    b.HasIndex("Idproducto");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Compra", b =>
                {
                    b.Property<int>("Idcompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCompra");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idcompra"), 1L, 1);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime");

                    b.Property<int>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("IDUsuario");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Idcompra");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.CompraDetalle", b =>
                {
                    b.Property<int>("Idcompra")
                        .HasColumnType("int")
                        .HasColumnName("IDCompra");

                    b.Property<int>("Idproducto")
                        .HasColumnType("int")
                        .HasColumnName("IDProducto");

                    b.Property<int>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.HasKey("Idcompra", "Idproducto");

                    b.HasIndex("Idproducto");

                    b.ToTable("CompraDetalle");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Plan", b =>
                {
                    b.Property<int>("Idplan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPlan");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idplan"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NombrePlan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Idplan")
                        .HasName("PK_Plan_1");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Producto", b =>
                {
                    b.Property<int>("Idproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDProducto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idproducto"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Idproducto")
                        .HasName("PK_Producto_1");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.Plan", "IdplanNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("Idplan");

                    b.Navigation("IdplanNavigation");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Carrito", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.Producto", "IdproductoNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("Idproducto")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Producto");

                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", "IdusuarioNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("Idusuario")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Usuario");

                    b.Navigation("IdproductoNavigation");

                    b.Navigation("IdusuarioNavigation");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.CompraDetalle", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.Compra", "IdcompraNavigation")
                        .WithMany("CompraDetalles")
                        .HasForeignKey("Idcompra")
                        .IsRequired()
                        .HasConstraintName("FK_CompraDetalle_Compra");

                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.Producto", "IdproductoNavigation")
                        .WithMany("CompraDetalles")
                        .HasForeignKey("Idproducto")
                        .IsRequired()
                        .HasConstraintName("FK_CompraDetalle_Producto");

                    b.Navigation("IdcompraNavigation");

                    b.Navigation("IdproductoNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.ApplicationUser", b =>
                {
                    b.Navigation("Carritos");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Compra", b =>
                {
                    b.Navigation("CompraDetalles");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Plan", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("HARDCOREGYMPIA.Models.dbModels.Producto", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("CompraDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
