using System.Collections;
using static System.Console;

namespace HelloWorld
{
    class Aula08EstruturaDeDadosTuplas
    {
        static void Aula8()
        {
            //(string, string, double) brasil = ("Brasil", "Brasilia", 1268.33);
            //WriteLine($"O {brasil.Item1}, cuja sua capital é {brasil.Item2} tem RPC de R$ {brasil.Item3}");

            (string pais, string tipoGoverno, int populacao, string capital, double rpc) brasil = ("Brasil", "Presidencialismo", 200, "Brasilia", 1268.33);
            WriteLine($"O {brasil.pais}, cuja sua capital é {brasil.capital} tem RPC de R$ {brasil.rpc} e a populacao de {brasil.populacao} tem o tipo de governo por {brasil.tipoGoverno}");

            ReadKey();
        }
    }
}
