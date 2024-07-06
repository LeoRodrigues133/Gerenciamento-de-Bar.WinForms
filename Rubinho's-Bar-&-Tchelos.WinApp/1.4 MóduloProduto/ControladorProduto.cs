using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto
{
    public class ControladorProduto : ControladorBase, IControladorEditavel
    {
        public override string TipoCadastro => "Produtos";

        public override string ToolTipAdicionar => "Cadastrar um novo produto";

        string IControladorEditavel.ToolTipEditar => "Editar um produto existente";

        public override string ToolTipExcluir => "Excluir um produto";

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        void IControladorEditavel.Editar()
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
