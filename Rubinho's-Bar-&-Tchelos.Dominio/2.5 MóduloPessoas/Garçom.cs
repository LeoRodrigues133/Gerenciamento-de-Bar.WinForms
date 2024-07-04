using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas
{
    public class Garçom : EntidadeBase
    {
        public string Nome { get; set; }

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
