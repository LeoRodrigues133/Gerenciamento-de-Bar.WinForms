namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract List<string> Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
