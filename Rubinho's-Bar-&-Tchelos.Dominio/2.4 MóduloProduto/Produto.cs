using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public int Quantia { get; set; }
        public decimal Valor { get; set; }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
            Quantia = 0;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
