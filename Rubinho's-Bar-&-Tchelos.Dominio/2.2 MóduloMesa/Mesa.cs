using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa
{
    public class Mesa : EntidadeBase
    {

        public int NumeroDaMesa { get; set; }

        public Mesa(int numeroDaMesa)
        {
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

        public string OrganizarMesas()
        {
            string Salao;

            if (NumeroDaMesa >= 110)
                Salao = $"Segundo Salão Mesa {NumeroDaMesa}";
            else if (NumeroDaMesa >= 210)
                Salao = $"Terceico Salão Mesa {NumeroDaMesa}";
            else
                Salao = $"Primeiro Salão Mesa {NumeroDaMesa}";

            return Salao;
        }

        public override string ToString()
        {
            return $"Mesa: n{NumeroDaMesa}";
        }
    }
}
