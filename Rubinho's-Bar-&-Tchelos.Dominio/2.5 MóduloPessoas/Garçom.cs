using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas
{
    public class Garçom : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Garçom(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Garçom a = (Garçom)novoRegistro;

            Nome = a.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" deve ser preenchido");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"Cpf\" deve ser preenchido");

            return erros;
        }

        public bool VerificarDualidade(List<Garçom> repositorioPessoas, Garçom garçom)
        {
            foreach(Garçom g in repositorioPessoas)
                if (g.Cpf == garçom.Cpf)
                    return false;

            return true;
        }

        public override string ToString()
        {
            return $"{ Nome} { Cpf}";
        }
    }
}
