using System;
using System.Globalization;
using static System.Console;

namespace IniciandoComCsharp
{
    class Aula15FuncoesDeStringFormat
    {
        static void Aula15()
        {
            string nome = "Kelvis Borges";
            int idade = 19;
            double rendimento = 8000.00;
            DateTime dataCadastro = new DateTime(2015, 05, 20);
            string str = "O cliente {0} tem {1} anos de idade de {2:c}";
            str += " e é cliente desde {3:dd/MM/yyyy}";

            // string frase = String.Format("O cliente {0} tem {1} anos de idade ", nome, idade);
            // WriteLine(frase);

            string frase = String.Format(str, nome, idade, rendimento, dataCadastro);
            WriteLine(frase);

            ReadKey();
        }
    }
}
