namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado
{
    public abstract class ControladorBase
    {
        public abstract string TipoCadastro { get; }
        public abstract string ToolTipAdicionar { get; }
        public abstract string ToolTipExcluir { get; }

        public abstract UserControl ObterListagem();
        public abstract void CarregarRegistros();
        public abstract void Adicionar();
        public abstract void Excluir();
    }
}
