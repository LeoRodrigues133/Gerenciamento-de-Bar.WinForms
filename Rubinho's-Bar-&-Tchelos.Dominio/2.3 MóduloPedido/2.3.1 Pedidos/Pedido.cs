using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos
{
    public class Pedido : EntidadeBase
    {
        public Produto Produto { get; set; }
        public int Quantidade {  get; set; }
        public Pedido(){}
        public Pedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public bool VerificarProduto(Pedido pedido, List<Produto> produtos)
        {
            Produto produto = pedido.Produto;

            Produto buscador = produtos.Find(x => x.Nome == produto.Nome)!;

            if (buscador == null)
                return false;

            return true;
        }


        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido a = (Pedido) novoRegistro;

            Produto = a.Produto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override string ToString()
        {
            return Produto.ToString();
        }
    }
}
