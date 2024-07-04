using System.Globalization;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string textoEscolhido)
        {
            string[] textoQuebrado = textoEscolhido.Split(' ');

            for (int i = 0; i < textoQuebrado.Length; i++)
            {
                string palavraMaiuscula = CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(textoQuebrado[i].ToLower());

                textoQuebrado[i] = palavraMaiuscula;
            }

            return string.Join(" ", textoQuebrado);
        }
    }
}
