namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido
{
    public interface IRepositorioComanda
    {
        void Cadastrar(Comanda novoRegistro);
        bool Editar(int id, Comanda editarRegistro);
        bool Excluir(int id);
        Comanda SelecionarPorId(int id);
        List<Comanda> SelecionarTodos();
    }
}
