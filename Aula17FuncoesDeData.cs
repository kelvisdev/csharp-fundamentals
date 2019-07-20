using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace IniciandoComCsharp
{
    class Aula17FuncoesDeData
    {
        static void Aula17()
        {
            string dataDoBanco = "2019-04-02 08:30:00";
            // DateTime data = new DateTime(2019, 04, 02, 08, 30, 00);
            DateTime data = DateTime.Parse(dataDoBanco);

            string horaFormatada = String.Format("{0:HH}h{0:mm}", data);
            string dataFormatada = String.Format("{0:dd/MM/yyyy}", data);

            WriteLine(data);
            WriteLine(horaFormatada);
            WriteLine(dataFormatada);

            // WriteLine("{0}", DateTime.Now.AddDays(2));

            ReadKey();
        }
    }
}
