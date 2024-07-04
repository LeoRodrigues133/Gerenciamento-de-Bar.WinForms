using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido
{
    public class Comanda : EntidadeBase
    {
        public List<Pedido> Pedidos { get; set; }
        public Garçom Garçom { get; set; }

        public Comanda(List<Pedido> pedidos, Garçom garçom)
        {
            Pedidos = pedidos;
            Garçom = garçom;
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
