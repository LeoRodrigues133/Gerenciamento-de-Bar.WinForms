using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp._MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public class ControladorPedido : ControladorBase, IControladorEditavel
    {
        TabelaPedidoControl tabelaPedido;
        List<Garçom> repositorioPessoas;
        public override string TipoCadastro => "Pedidos";
        public string ToolTipEditar => "Editar um pedido existente";

        public override string ToolTipExcluir => "Excluir um pedido existente";

        public override string ToolTipAdicionar => "Cadastrar um novo pedido";

        public override void Adicionar()
        {
            TelaPedidoForm tela = new TelaPedidoForm(this);

            carregarProdutos(tela);
            CarregarDados(tela);
            DialogResult resultado = tela.ShowDialog();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPedido == null)
                tabelaPedido = new();

            return tabelaPedido;
        }

        public void carregarProdutos(TelaPedidoForm telaPedido)
        {
            TelaProdutoForm telaProduto = new();

            List<Produto> Lista = telaProduto.produtos;

            telaPedido.CarregarComboBoxProdutos(Lista);
        }

        void CarregarDados(TelaPedidoForm telaPedido)
        {
            TelaPessoasForm controladorPessoas = new();
            ControladoMesa controladorMesa = new ControladoMesa();

            List<Mesa> mesas = controladorMesa.mesas;
            List<Garçom> garçoms = controladorPessoas.repositorioPessoas;

            telaPedido.CarregarComboBoxPedido(garçoms, mesas);
        }
    }
}
