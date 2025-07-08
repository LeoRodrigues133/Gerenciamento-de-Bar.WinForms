﻿using Microsoft.EntityFrameworkCore;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado
{
    public class BotecoDbContext : DbContext
    {
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Garçom> Garçons { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=GestaoDeBarDb;Integrated Security=True;Pooling=False;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id).IsRequired().ValueGeneratedOnAdd();

                mesaBuilder.Property(m => m.NumeroDaMesa).IsRequired().HasColumnType("int");

                mesaBuilder.Property(m => m.Status).IsRequired().HasColumnType("bit");

            });
            modelBuilder.Entity<Pedido>(pedidoBuilder =>
            {

                pedidoBuilder.ToTable("TBPedido");

                pedidoBuilder.Property(pd => pd.Id).IsRequired().ValueGeneratedOnAdd();

                pedidoBuilder.Property(pd => pd.Quantidade).IsRequired().HasColumnType("int");

                pedidoBuilder.HasOne(pd => pd.Produto).WithMany()
                .IsRequired()
                .HasForeignKey("Produto_Id")
                .HasConstraintName("FK_TBPedido_TBProduto")
                .OnDelete(DeleteBehavior.NoAction);

            });
            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

                produtoBuilder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(100)");

                produtoBuilder.Property(p => p.Valor).IsRequired().HasColumnType("varchar(30)");

                produtoBuilder.Property(p => p.CategoriaProduto).IsRequired().HasConversion<int>();
            });

            modelBuilder.Entity<Garçom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarçom");

                garcomBuilder.Property(g => g.Id).IsRequired().ValueGeneratedOnAdd();

                garcomBuilder.Property(g => g.Nome).IsRequired().HasColumnType("varchar(100)");

                garcomBuilder.Property(g => g.Cpf).IsRequired().HasColumnType("varchar(50)");

                garcomBuilder.Property(g => g.Cargo).IsRequired().HasColumnType("int");

            });

            modelBuilder.Entity<Comanda>(comandaBuilder =>
            {
                comandaBuilder.ToTable("TBComanda");

                comandaBuilder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();

                comandaBuilder.HasOne(c => c.Mesa).WithMany()
                .IsRequired()
                .HasForeignKey("Mesa_Id")
                .HasConstraintName("FK_TBComanda_TBMesa")
                .OnDelete(DeleteBehavior.NoAction);

                comandaBuilder.HasOne(c => c.Garçom).WithMany(g => g.Comandas)
                .IsRequired()
                .HasForeignKey("Garcom_Id")
                .HasConstraintName("FK_TBComanda_TBGarcom")
                .OnDelete(DeleteBehavior.NoAction);

                comandaBuilder.HasMany(c => c.Pedidos).WithOne().HasForeignKey("Conta_Id");

                comandaBuilder.Property(c => c.Status).IsRequired().HasColumnType("int");

                comandaBuilder.Property(c => c.ValorTotal).IsRequired().HasColumnType("decimal");

                comandaBuilder.Property(c => c.DataConclusao).HasColumnType("datetime");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}