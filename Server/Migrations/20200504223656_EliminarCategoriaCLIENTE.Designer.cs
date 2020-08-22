﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurcosBlazor.Server.Context;

namespace SurcosBlazor.Server.Migrations
{
    [DbContext(typeof(WebApiDbContext))]
    [Migration("20200504223656_EliminarCategoriaCLIENTE")]
    partial class EliminarCategoriaCLIENTE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.CategoriaCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categoriaCliente");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.CategoriaClienteTipoListaPrecio", b =>
                {
                    b.Property<int>("CategoriaClienteId")
                        .HasColumnType("int");

                    b.Property<int>("TipoListaPrecioId")
                        .HasColumnType("int");

                    b.Property<bool>("habilitada")
                        .HasColumnType("bit");

                    b.HasKey("CategoriaClienteId", "TipoListaPrecioId");

                    b.HasIndex("TipoListaPrecioId");

                    b.ToTable("categoriaClienteTipoListaPrecio");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<string>("cuit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<string>("nombreComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("saldoCC")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaClienteId");

                    b.HasIndex("DomicilioId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.Property<bool>("eCommerce")
                        .HasColumnType("bit");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("departamento");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.DetalleListaPrecios", b =>
                {
                    b.Property<int>("ListaPreciosId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoPresentacionId")
                        .HasColumnType("int");

                    b.Property<double>("IVA")
                        .HasColumnType("float");

                    b.Property<int>("cantidadMinima")
                        .HasColumnType("int");

                    b.Property<double>("porcentajeDescuento")
                        .HasColumnType("float");

                    b.Property<double>("porcentajeRentabilidad")
                        .HasColumnType("float");

                    b.Property<double>("precioCosto")
                        .HasColumnType("float");

                    b.Property<double>("precioUnitarioFinal")
                        .HasColumnType("float");

                    b.Property<double>("precioUnitarioNeto")
                        .HasColumnType("float");

                    b.HasKey("ListaPreciosId", "ProductoPresentacionId");

                    b.HasIndex("ProductoPresentacionId");

                    b.ToTable("detalleListaPrecios");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.DetallePedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoPresentacionId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<double>("descuento")
                        .HasColumnType("float");

                    b.Property<double>("precioUnitario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoPresentacionId");

                    b.ToTable("detallePedido");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.Property<string>("calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manzana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("piso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("domicilio");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DomicilioId");

                    b.ToTable("entrega");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.EstadoListaPrecios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("estadoListaPrecios");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.EstadoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("estadoPedido");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.ListaPrecios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstadoListaPreciosId")
                        .HasColumnType("int");

                    b.Property<int>("EstadpListaPreciosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EstadoListaPreciosId");

                    b.ToTable("listaPrecios");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntregaId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ListaPreciosId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EstadoPedidoId");

                    b.HasIndex("ListaPreciosId");

                    b.HasIndex("VendedorId");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.PresentacionProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UnidadId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("unidades")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UnidadId");

                    b.ToTable("presentacionProducto");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.ProductoPresentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PresentacionProductoId")
                        .HasColumnType("int");

                    b.Property<double>("costo")
                        .HasColumnType("float");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("esFormulado")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PresentacionProductoId");

                    b.ToTable("productoPresentaciones");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("eCommerce")
                        .HasColumnType("bit");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("provincias");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.TipoListaPrecio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tipoListaPrecio");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Unidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("unidad");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("eCommerce")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trabajaFeriado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DomicilioId");

                    b.ToTable("vendedor");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.VendedorDepartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.Property<bool>("enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaDomingo")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaJueves")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaLunes")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaMartes")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaMiercoles")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaSabado")
                        .HasColumnType("bit");

                    b.Property<bool>("entregaViernes")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("VendedorId");

                    b.ToTable("vendedorDepartamento");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.CategoriaClienteTipoListaPrecio", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.CategoriaCliente", "CategoriaCliente")
                        .WithMany("CategoriaClienteTiposListaPrecio")
                        .HasForeignKey("CategoriaClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.TipoListaPrecio", "TipoListaPrecio")
                        .WithMany("CategoriaClienteTiposListaPrecio")
                        .HasForeignKey("TipoListaPrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Cliente", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.CategoriaCliente", "Categoria")
                        .WithMany("Cliente")
                        .HasForeignKey("CategoriaClienteId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SurcosBlazor.Shared.Entidades.Domicilio", "Domicilio")
                        .WithMany()
                        .HasForeignKey("DomicilioId");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Departamento", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Provincia", "Provincia")
                        .WithMany("departamentos")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.DetalleListaPrecios", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.ListaPrecios", null)
                        .WithMany("DetalleListaPrecios")
                        .HasForeignKey("ListaPreciosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.ProductoPresentacion", "ProductoPresentacion")
                        .WithMany()
                        .HasForeignKey("ProductoPresentacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.DetallePedido", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Pedido", null)
                        .WithMany("detallePedido")
                        .HasForeignKey("PedidoId");

                    b.HasOne("SurcosBlazor.Shared.Entidades.ProductoPresentacion", "ProductoPresentacion")
                        .WithMany()
                        .HasForeignKey("ProductoPresentacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Domicilio", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("SurcosBlazor.Shared.Entidades.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Entrega", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Domicilio", "domicilio")
                        .WithMany()
                        .HasForeignKey("DomicilioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.ListaPrecios", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.EstadoListaPrecios", "EstadoListaPrecios")
                        .WithMany()
                        .HasForeignKey("EstadoListaPreciosId");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Pedido", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Entrega", "Entrega")
                        .WithMany()
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.EstadoPedido", "EstadoPedido")
                        .WithMany()
                        .HasForeignKey("EstadoPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.ListaPrecios", "ListaPrecios")
                        .WithMany()
                        .HasForeignKey("ListaPreciosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.PresentacionProducto", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Unidad", "Unidad")
                        .WithMany()
                        .HasForeignKey("UnidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.ProductoPresentacion", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.PresentacionProducto", "PresentacionProducto")
                        .WithMany()
                        .HasForeignKey("PresentacionProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.Vendedor", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Domicilio", "domicilio")
                        .WithMany()
                        .HasForeignKey("DomicilioId");
                });

            modelBuilder.Entity("SurcosBlazor.Shared.Entidades.VendedorDepartamento", b =>
                {
                    b.HasOne("SurcosBlazor.Shared.Entidades.Departamento", "departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurcosBlazor.Shared.Entidades.Vendedor", null)
                        .WithMany("VendedorDepartamento")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
