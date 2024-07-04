using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido
{
    public class Pedido : EntidadeBase
    {
        public List<Produto> Produtos { get; set; }
        public int QtdProduto { get; set; }

        public Pedido(List<Produto> produtos, int qtdProduto)
        {
            Produtos = produtos;
            QtdProduto = qtdProduto;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
