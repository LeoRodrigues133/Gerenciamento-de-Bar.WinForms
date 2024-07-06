using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas
{
    public partial class TabelaPessoaControl : UserControl
    {
        public TabelaPessoaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

        }

        public void AtualizarRegistros(List<Garçom> repositorio)
        {
            grid.Rows.Clear();

            foreach (Garçom p in repositorio)
                grid.Rows.Add(p.Id.ToString(), p.Nome, p.Cpf);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf"}
                };
        }
    }
}
