namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas
{
    public interface IRepositorioPessoas
    {
        void Cadastrar(Garçom novoRegistro);
        bool Editar(int id, Garçom editarRegistro);
        bool Excluir(int id);
        Garçom SelecionarPorId(int id);
        List<Garçom> SelecionarTodos();
    }
}
