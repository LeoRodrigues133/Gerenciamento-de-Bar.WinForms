using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

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
            throw new NotImplementedException();
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
    }
}
