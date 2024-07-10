using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos
{
    public class Pedido : EntidadeBase
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Pedido() { }
        //public Comanda Comanda { get; set; }
        public Pedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido a = (Pedido)novoRegistro;

            Produto = a.Produto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override string ToString()
        {
            return $"{Quantidade}x {Produto} {Produto.Valor:C2}";
        }
    }
}
