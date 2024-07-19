using Microsoft.EntityFrameworkCore;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPedido
{
    public class RepositorioPedidoEmOrm : IRepositorioComanda
    {

        BotecoDbContext dbContext;

        public RepositorioPedidoEmOrm(BotecoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Comanda novoRegistro)
        {
            dbContext.Comandas.Add(novoRegistro);
            dbContext.SaveChanges();

        }

        public bool Editar(int id, Comanda editarRegistro)
        {
            Comanda comandaSelecionada = dbContext.Comandas.Include(p => p.Pedidos).FirstOrDefault(c => c.Id == id)!;

            if (comandaSelecionada == null)
                return false;

            comandaSelecionada.AtualizarRegistro(editarRegistro);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Comanda comandaSelecionada = dbContext.Comandas.Include(x => x.Pedidos).FirstOrDefault(p => p.Id == id)!;

            if (comandaSelecionada == null)
                return false;

            dbContext.Pedidos.RemoveRange(comandaSelecionada.Pedidos);

            dbContext.Comandas.Remove(comandaSelecionada);
            dbContext.SaveChanges();

            return true;
        }

        public Comanda SelecionarPorId(int id)
        {
            return dbContext.Comandas.Include(c => c.Mesa).Include(c => c.Garçom).Include(c => c.Pedidos).FirstOrDefault(c => c.Id == id)!;
        }

        public List<Comanda> SelecionarTodos()
        {
            return dbContext.Comandas.Include(x => x.Pedidos).ToList();
        }
    }
}
