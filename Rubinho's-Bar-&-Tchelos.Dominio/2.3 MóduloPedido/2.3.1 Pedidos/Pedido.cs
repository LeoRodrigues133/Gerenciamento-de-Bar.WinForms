using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos
{
    public class Pedido : EntidadeBase
    {
        public List<Produto> Produtos { get; set; }
        public Pedido(){}
        public Pedido(List<Produto> produtos)
        {
            Produtos = produtos;

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido a = (Pedido) novoRegistro;

            Produtos = a.Produtos;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override string ToString()
        {
            return Convert.ToString(Produtos.Count()) ;
        }
    }
}
