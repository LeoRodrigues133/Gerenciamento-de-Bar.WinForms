﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;

#nullable disable

namespace Rubinho_s_Bar___Tchelos.Infra.Migrations
{
    [DbContext(typeof(BotecoDbContext))]
    [Migration("20240715050530_Full-migration")]
    partial class Fullmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NumeroDaMesa")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TBMesa", (string)null);
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataConclusao")
                        .HasColumnType("datetime");

                    b.Property<int>("Garcom_Id")
                        .HasColumnType("int");

                    b.Property<int>("Mesa_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("Garcom_Id");

                    b.HasIndex("Mesa_Id");

                    b.ToTable("TBComanda", (string)null);
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Conta_Id")
                        .HasColumnType("int");

                    b.Property<int>("Produto_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Conta_Id");

                    b.HasIndex("Produto_Id");

                    b.ToTable("TBPedido", (string)null);
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas.Garçom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBGarçom", (string)null);
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaProduto")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TBProduto", (string)null);
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Comanda", b =>
                {
                    b.HasOne("Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas.Garçom", "Garçom")
                        .WithMany("Comandas")
                        .HasForeignKey("Garcom_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBComanda_TBGarcom");

                    b.HasOne("Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa.Mesa", "Mesa")
                        .WithMany()
                        .HasForeignKey("Mesa_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBComanda_TBMesa");

                    b.Navigation("Garçom");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos.Pedido", b =>
                {
                    b.HasOne("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Comanda", null)
                        .WithMany("Pedidos")
                        .HasForeignKey("Conta_Id");

                    b.HasOne("Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Produto_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBPedido_TBProduto");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Comanda", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas.Garçom", b =>
                {
                    b.Navigation("Comandas");
                });
#pragma warning restore 612, 618
        }
    }
}
