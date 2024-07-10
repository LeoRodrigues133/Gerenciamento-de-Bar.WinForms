using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido
{
    public class Comanda : EntidadeBase
    {
        public decimal ValorTotal { get; set; }
        public Mesa Mesa { get; set; }
        public Garçom Garçom { get; set; }
        public EnumStatusPagamento Status { get; set; }
        public List<Pedido> Pedido { get; set; }
        public Comanda() { }

        public Comanda(Garçom garçom, EnumStatusPagamento status, Mesa mesa, List<Pedido> pedido)
        {
            Mesa = mesa;
            Status = status;
            Pedido = pedido;
            Garçom = garçom;
            CalcularValor(pedido);
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Comanda a = (Comanda)novoRegistro;

            Pedido = a.Pedido;
        }

        public override List<string> Validar()
        {
            List<string> erros = new();

            if (Garçom.Id == null)
                erros.Add("Não é possivel iniciar uma comanda sem definir um garçom");

            if (Mesa.Id == null)
                erros.Add("Não é possivel iniciar uma comanda sem definir uma mesa");

            if (Status == null)
                erros.Add("Não é possível iniciar uma comanda sem definir o status de pagamento");

            if (Pedido == null)
                erros.Add("Deve haver ao menos um produto no pedido para iniciar a comanda");

            return erros;
        }

        void CalcularValor(List<Pedido> pedidos)
        {
            ValorTotal = 0;

            foreach (Pedido p in pedidos)
            {
                p.Produto.Valor += ValorTotal;
            }
        }
    }
}
