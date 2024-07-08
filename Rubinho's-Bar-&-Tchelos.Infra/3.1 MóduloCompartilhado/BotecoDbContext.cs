using Microsoft.EntityFrameworkCore;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado
{
    public class BotecoDbContext : DbContext
    {
        public DbSet<Mesa> Mesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BotecoDb;Integrated Security=True;Pooling=False;Encrypt=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                mesaBuilder.Property(m => m.NumeroDaMesa)
                    .IsRequired()
                    .HasColumnType("int");
            });

            modelBuilder.Ignore<Produto>();
            modelBuilder.Ignore<Pedido>();

            base.OnModelCreating(modelBuilder);
        }
    }
}