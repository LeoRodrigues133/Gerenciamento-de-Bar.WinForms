using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa
{
    public class RepositorioMesaEmOrm : IRepositorioMesa
    {
        BotecoDbContext dbContext;
        public RepositorioMesaEmOrm(BotecoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Mesa novoRegistro)
        {
            dbContext.Mesas.Add(novoRegistro);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Mesa editarRegistro)
        {
            Mesa mesaSelecionada = dbContext.Mesas.Find(id)!;

            if (mesaSelecionada == null)
                return false;

            mesaSelecionada.AtualizarRegistro(editarRegistro);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Mesa mesaSelecionada = dbContext.Mesas.Find(id)!;

            if(mesaSelecionada == null)
                return false;

            dbContext.Remove(mesaSelecionada);
            dbContext.SaveChanges();

            return true;
        }

        public Mesa SelecionarPorId(int id)
        {
            return dbContext.Mesas.Find(id)!;
        }

        public List<Mesa> SelecionarTodos()
        {
            return dbContext.Mesas.ToList();
        }
    }
}
