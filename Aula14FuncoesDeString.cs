using System.Globalization;
using static System.Console;

namespace IniciandoComCsharp
{
    class Aula14FuncoesDeString
    {
        static void Aula14()
        {
            string frase = "Hoje à noite, sem luz, decidi xeretar a quinta gaveta de vovô: achei linguica, pão e fuba";
            string termo = "quinta";

            // Cria Subtring a partir da posicao inicial e/ou seu tamanho
            int posInicial = frase.IndexOf(termo);
            int tamanho = 10;
            string substring = frase.Substring(posInicial, tamanho);
            WriteLine(substring.ToUpper());
            WriteLine(substring.ToLower());

            WriteLine($"Qtde Caracteres {frase.Length}");

            // Posicao onde esta termo
            int pos = frase.IndexOf(termo);
            WriteLine($"Posicao onde está termo: {pos}");

            // Se termo subrase em frase
            var achou = frase.Contains(termo);
            WriteLine($"Achou: {achou}");

            // Quebra em partes por virgula
            string[] partes = frase.Split(",");
            for (int i = 0; i < partes.Length; i++)
                WriteLine($"Partes {partes[i].Trim()}");

            //
            string frase_trocada = frase.Replace("Hoje", "Ontem");
            string frase_trocada2 = frase.Replace("hOjE", "Ontem", true, CultureInfo.CurrentCulture);
            WriteLine(frase_trocada);
            WriteLine(frase_trocada2);

            ReadLine();

        }
    }
}
