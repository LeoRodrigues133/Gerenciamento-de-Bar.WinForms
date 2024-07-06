using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp._1._5_MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas;

namespace Rubinho_s_Bar___Tchelos.WinApp._MóduloPessoas
{
    public class ControladorPessoas : ControladorBase, IControladorEditavel
    {

        RepositorioPessoasEmOrm repositorioPessoas;
        TabelaPessoaControl tabelaPessoas;
        List<Garçom> a = new();
        public ControladorPessoas(RepositorioPessoasEmOrm rPessoas)
        {
            repositorioPessoas = rPessoas;
        }

        public override string TipoCadastro => "Pessoas";

        public override string ToolTipAdicionar => "Cadastrar uma nova pessoa";

        string IControladorEditavel.ToolTipEditar => "Editar um cadastro de pessoa";

        public override string ToolTipExcluir => "Excluir um cadastro de pessoa";

        public override void Adicionar()
        {
            TelaPessoasForm tela = new TelaPessoasForm(a);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Garçom novoGarçom = tela.Garçom;

            List<Garçom> funcionarios = repositorioPessoas.SelecionarTodos();

            foreach (Garçom p in funcionarios)
            {
                if (p.Cpf == novoGarçom.Cpf)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Já existe um funcionário com este Cpf registrado");
                    return;
                }
            }

            repositorioPessoas.Cadastrar(novoGarçom);

            CarregarPessoas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoGarçom.Nome}\" foi criado com sucesso!");

        }

        void IControladorEditavel.Editar()
        {
            TelaPessoasForm tela = new TelaPessoasForm(a);

            int idSelecionado = tabelaPessoas.ObterRegistroSelecionado();

            Garçom Selecionado = repositorioPessoas.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            tela.Garçom = Selecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Garçom funcionarioEditado = tela.Garçom;

            repositorioPessoas.Editar(Selecionado.Id, funcionarioEditado);

            CarregarPessoas();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaPessoas.ObterRegistroSelecionado();

            Garçom Selecionado = repositorioPessoas.SelecionarPorId(idSelecionado);

            if(Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente demitir o \"{Selecionado.Nome}\"?",
                "Confirmar Demissão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(resultado != DialogResult.Yes) return;

            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Você demitiu {Selecionado.Nome}!");
            
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPessoas == null)
                tabelaPessoas = new TabelaPessoaControl();

            //CarregarPessoas();

            return tabelaPessoas;
        }

        private void CarregarPessoas()
        {
            List<Garçom> pessoas = repositorioPessoas.SelecionarTodos();

            tabelaPessoas.AtualizarRegistros(pessoas);
        }
    }
}
