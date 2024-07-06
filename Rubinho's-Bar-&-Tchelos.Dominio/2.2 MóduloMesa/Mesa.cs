using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa
{
    public class Mesa : EntidadeBase
    {

        public int NumeroDaMesa { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Mesa()
        {
            NumeroDaMesa = NumeroDaMesas();
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }

        int NumeroDaMesas()
        {
            List<Mesa> Salao = new();

            Salao.Add(this);
            
            int i = 0;

            foreach (Mesa mesa in Salao)
            {
                i += 10;
            }
            return i;
        }
    }
}
