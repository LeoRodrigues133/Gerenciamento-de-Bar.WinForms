using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public class ControladorPedido : ControladorBase, IControladorEditavel
    {
        public override string TipoCadastro => "Pedidos";
        public string ToolTipEditar => "Editar um pedido existente";

        public override string ToolTipExcluir => "Excluir um pedido existente";

        public override string ToolTipAdicionar => "Cadastrar um novo pedido";

        public override void Adicionar()
        {
            TelaPedidoForm tela = new TelaPedidoForm();

            carregarProdutos(tela);
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
            throw new NotImplementedException();
        }

        void carregarProdutos(TelaPedidoForm telaPedido)
        {
            TelaProdutoForm t = new();


            List<Produto> a = t.produtos;

            telaPedido.povoarcboxproduto(a);

        }
    }
}
