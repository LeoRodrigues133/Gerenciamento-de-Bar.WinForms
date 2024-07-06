using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    public class ControladoMesa : ControladorBase
    {

        RepositorioMesaEmOrm repositorioMesas;
        TabelaMesaControl tabelaMesas;
        public List<Mesa> mesas = new List<Mesa>();
        TelaMesaForm tela;

        public override string TipoCadastro => "Mesas";

        public override string ToolTipAdicionar => "Adicionar uma nova mesa no salão";


        public override string ToolTipExcluir => "Remover uma mesa do salão";


        public ControladoMesa()
        {
            
        }
        public override void Adicionar()
        {
            Mesa novaMesa = new Mesa();

            mesas.Add(novaMesa);

            //repositorioMesas.Cadastrar(novaMesa);

            CarregarMesas(tela);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma nova mesa foi adicionada com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMesas.ObterRegistroSelecionado();

            Mesa mesaSelecionada = repositorioMesas.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível realizar esta ação sem nenhuma mesa selecionada");
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Você realmente deseja excluir a mesa N{mesaSelecionada.NumeroDaMesa}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                repositorioMesas.Excluir(mesaSelecionada.Id);
                return;
            }

            CarregarMesas(tela);

            TelaPrincipalForm.Instancia.AtualizarRodape("O mesa foi removida com sucesso");

        }

        public override UserControl ObterListagem()
        {
            if (tabelaMesas == null)
                tabelaMesas = new TabelaMesaControl();

            CarregarMesas(tela);

            return tabelaMesas;

        }
        private void CarregarMesas(TelaMesaForm tela)
        {
            List<Mesa> mesas = repositorioMesas.SelecionarTodos();

            tabelaMesas.AtualizarRegistros(mesas);

        }
    }
}
