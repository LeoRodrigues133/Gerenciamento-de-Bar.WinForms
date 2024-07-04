namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa
{
    public interface IRepositorioMesa
    { 
        void Cadastrar(Mesa novoRegistro);
        bool Editar(int id, Mesa editarRegistro);
        bool Excluir(int id);
        Mesa SelecionarPorId(int id);
        List<Mesa> SelecionarTodos();
    }
}
