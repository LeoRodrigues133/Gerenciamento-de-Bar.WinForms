namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto
{
    public interface IRepositorioProduto
    {
        void Cadastrar(Produto novoRegistro);
        bool Editar(int id, Produto editarRegistro);
        bool Excluir(int id);
        Produto SelecionarPorId(int id);
        List<Produto> SelecionarTodos();
    }
}
