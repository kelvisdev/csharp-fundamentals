using System;
using static System.Console;

namespace HelloWorld
{
    class Aula09EstruturaDeDecisaoIfElseifElse
    {
        static void Aula9()
        {
            double salario = 0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;

            Write("Informe seu salario: ");
            salario = Convert.ToDouble(ReadLine());

            Write("Informe seu gasto mensal: ");
            gastosMensais = Convert.ToDouble(ReadLine());

            Write("Tem Décimo Terceiro? ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if (temDecimoTerceiro)
            {
                salario += salario;
            }

            if (gastosMensais > salario)
            {
                WriteLine("Precisa economizar!");
            }
            else if (gastosMensais == salario)
            {
                WriteLine("Ufa! Foi por pouco! To Zerado!");
            }
            else
            {
                WriteLine("Legal! Sobrou dinheiro pro X-tudo!");
            }


            ReadKey();
        }
    }
}
