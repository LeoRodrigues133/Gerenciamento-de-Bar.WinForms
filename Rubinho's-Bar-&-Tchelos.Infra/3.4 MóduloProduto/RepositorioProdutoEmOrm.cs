using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Infra.MóduloProduto
{
    public class RepositorioProdutoEmOrm : IRepositorioProduto
    {
        BotecoDbContext dbContext;
        public RepositorioProdutoEmOrm(BotecoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Cadastrar(Produto novoRegistro)
        {/*

            dbContext.Produtos.Add(novoRegistro);
            dbContext.SaveChanges();*/
        }

        public bool Editar(int id, Produto editarRegistro)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Produto SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
