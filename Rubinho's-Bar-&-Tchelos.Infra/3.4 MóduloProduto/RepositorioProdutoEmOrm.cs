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
        {

            dbContext.Produtos.Add(novoRegistro);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Produto editarRegistro)
        {
            Produto produtoSelecionado = dbContext.Produtos.Find(id);

            if (produtoSelecionado == null)
                return false;

            produtoSelecionado.AtualizarRegistro(editarRegistro);

            dbContext.SaveChanges();
            
            return true;
        }

        public bool Excluir(int id)
        {
            Produto produtoSelecionado = dbContext.Produtos.Find(id);

            if (produtoSelecionado == null)
                return false;

            dbContext.Produtos.Remove(produtoSelecionado);
            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int id)
        {
            return dbContext.Produtos.Find(id);
        }

        public List<Produto> SelecionarTodos()
        {
            return dbContext.Produtos.ToList();
        }
    }
}
