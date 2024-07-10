using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto
{
    public class ControladorProduto : ControladorBase, IControladorEditavel
    {
        IRepositorioProduto repositorioProduto;
        TabelaProdutoControl tabelaProduto;

        public ControladorProduto(IRepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }

        public override string TipoCadastro => "Produtos";
        public override string ToolTipAdicionar => "Cadastrar um novo produto";
        string IControladorEditavel.ToolTipEditar => "Editar produto existente";
        public override string ToolTipExcluir => "Excluir produto";

        public override void Adicionar()
        {
            TelaProdutoForm telaProduto = new TelaProdutoForm();

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Produto novoProduto = telaProduto.Produto;

            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            foreach (Produto p in produtos)
            {
                if (p.Nome == novoProduto.Nome)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Já existe um produto com este nome registrado");
                    return;
                }
            }

            repositorioProduto.Cadastrar(novoProduto);

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoProduto.Nome}\" foi criado com sucesso!");

            CarregarRegistros();
        }

        void IControladorEditavel.Editar()
        {
            TelaProdutoForm tela = new TelaProdutoForm();

            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto Selecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            tela.Produto = Selecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Produto produtoEditado = tela.Produto;

            repositorioProduto.Editar(Selecionado.Id, produtoEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto Selecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o \"{Selecionado.Nome}\"?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Você demitiu {Selecionado.Nome}!");

        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarRegistros();

            return tabelaProduto;
        }

        public override void CarregarRegistros()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(produtos);
        }
    }
}
