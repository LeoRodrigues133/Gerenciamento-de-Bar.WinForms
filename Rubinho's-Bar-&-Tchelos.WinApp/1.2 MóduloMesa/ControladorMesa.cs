using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    public class ControladorMesa : ControladorBase
    {

        public IRepositorioMesa repositorioMesas;

        public TabelaMesaControl tabelaMesas;


        public override string TipoCadastro => "Mesas";
        public override string ToolTipAdicionar => "Adicionar uma nova mesa no salão";
        public override string ToolTipExcluir => "Remover uma mesa do salão";

        public ControladorMesa(IRepositorioMesa repositorioMesas)
        {
            this.repositorioMesas = repositorioMesas;
        }
        public override void Adicionar()
        {

            int EnumeradorDeMesas = repositorioMesas.SelecionarTodos().Count() * 10;

            Mesa novaMesa = new Mesa(EnumeradorDeMesas);

            repositorioMesas.Cadastrar(novaMesa);

            CarregarRegistros();

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
                $"Você realmente deseja excluir a mesa Numero {mesaSelecionada.NumeroDaMesa}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                repositorioMesas.Excluir(mesaSelecionada.Id);
                CarregarRegistros();
                TelaPrincipalForm.Instancia.AtualizarRodape("O mesa foi removida com sucesso");
                return;
            }


        }

        public override void CarregarRegistros()
        {
            List<Mesa> mesas = repositorioMesas.SelecionarTodos();

            tabelaMesas.AtualizarRegistros(mesas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMesas == null)
                tabelaMesas = new TabelaMesaControl();

            CarregarRegistros();

            return tabelaMesas;
        }
    }
}
