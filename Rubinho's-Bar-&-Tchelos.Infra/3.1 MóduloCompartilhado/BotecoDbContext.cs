using Microsoft.EntityFrameworkCore;
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
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Garçom> Garçons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BotecoDb;Integrated Security=True;Pooling=False;Encrypt=True;";

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

            });
            modelBuilder.Entity<Comanda>(comandaBuilder =>
            {
                comandaBuilder.ToTable("TBComanda");

                comandaBuilder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();

                comandaBuilder.Property(c => c.Mesa).IsRequired().HasColumnType("int");
                comandaBuilder.Property(c => c.Garçom).IsRequired().HasColumnType("varchar(30)");
                comandaBuilder.Property(c => c.Status).IsRequired().HasColumnType("varchar(30)");
                comandaBuilder.Property(c => c.Pedido).IsRequired().HasColumnType("int");

            });
            modelBuilder.Entity<Pedido>(pedidoBuilder =>
            {

                pedidoBuilder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

                pedidoBuilder.Property(p => p.Produtos.Count()).IsRequired().HasColumnType("int");

            });
            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

                produtoBuilder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(100)");
                produtoBuilder.Property(p => p.Quantia).IsRequired().HasColumnType("int");
                produtoBuilder.Property(p => p.Valor).IsRequired().HasColumnType("varchar(30)");
                produtoBuilder.Property(p => p.CategoriaProduto).IsRequired().HasColumnType("int");
            });
            modelBuilder.Entity<Garçom>(garcomBuilder =>
            {
                garcomBuilder.Property(g => g.Id).IsRequired().ValueGeneratedOnAdd();

                garcomBuilder.Property(g => g.Nome).IsRequired().HasColumnType("varchar(100)");
                garcomBuilder.Property(g => g.Cpf).IsRequired().HasColumnType("varchar(50)");
                garcomBuilder.Property(g => g.Cargo).IsRequired().HasColumnType("int");

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}