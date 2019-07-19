using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace AvancandoCSharp
{
    class Aula16FuncoesDeStringBuilder
    {
        static void Aula16()
        {
            var frases = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            frases += "Fusce sollicitudin mi purus, ac tristique lacus pellentesque eget";
            frases += "Suspendisse cursus odio in diam porta, quis posuere diam sodales";
            frases += "Phasellus commodo erat pellentesque lacus porttitor, vel facilisis velit dictum.";
            frases += "Maecenas luctus quam cursus nisl vulputate auctor eget nec dui";

            StringBuilder builder = new StringBuilder();
            builder.Append("Fusce sollicitudin mi purus, ac tristique lacus pellentesque eget");
            builder.Append("Suspendisse cursus odio in diam porta, quis posuere diam sodales");
            builder.AppendLine("Phasellus commodo erat pellentesque lacus porttitor, vel facilisis velit dictum.");
            builder.Append("Maecenas luctus quam cursus nisl vulputate auctor eget nec dui");

            string nome = "Kelvis Borges";
            int idade = 19;
            double rendimento = 8000.00;
            DateTime dataCadastro = new DateTime(2015, 05, 20);
            StringBuilder frase = new StringBuilder("\n\nO cliente {0} tem {1} anos de idade de {2:c}");
            frase.Append(" e é cliente desde {3:dd/MM/yyyy}");
            builder.AppendFormat(frase.ToString(), nome, idade, rendimento, dataCadastro);

            WriteLine(builder);

            ReadKey();
        }
    }
}
