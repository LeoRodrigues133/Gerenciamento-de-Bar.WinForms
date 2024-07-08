using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public int Quantia { get; set; }
        public decimal Valor { get; set; }
        public EnumCategoriaProduto CategoriaProduto { get; set; }

        public Produto(){}

        public Produto(string nome, decimal valor, EnumCategoriaProduto categoria)
        {
            Nome = nome;
            Valor = valor;
            CategoriaProduto = categoria;
            Quantia = 0;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto a = (Produto)novoRegistro;

            Nome = a.Nome;
            Valor = a.Valor;
            CategoriaProduto = a.CategoriaProduto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("Não é possível cadastrar um produto sem nome");

            if (Valor == null || Valor <= 0)
                erros.Add("O produto não pode ser cadastrado sem valor");

            if (CategoriaProduto == null)
                erros.Add("O produto deve ser cadastrado dentro de uma categoria");

            return erros;

        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
