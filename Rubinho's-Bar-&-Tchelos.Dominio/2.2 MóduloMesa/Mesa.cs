using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa
{
    public class Mesa : EntidadeBase
    {

        public int NumeroDaMesa { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Mesa(List<Pedido> pedidos, int numeroDaMesa)
        {
            Pedidos = pedidos;
            NumeroDaMesa = numeroDaMesa;
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
