using System;
using static System.Console;

namespace IniciandoComCsharp
{
    class Aula10EstruturaDeDecisaoSwitchCase
    {
        static void Aula10()
        {


            WriteLine("Informe o saldo do cartao/banco: ");
            var eSaldo = Convert.ToDouble(ReadLine());

            WriteLine("Informe o valor da Compra: ");
            var eValor = Convert.ToDouble(ReadLine());

            WriteLine("Informe o tipo de pagamento(C para credito e D para debito): ");
            char eTipo = Convert.ToChar(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            //switch (pagamento.tipo)
            //{
            //    case 'C':
            //        WriteLine("Compra com cartão de credito!");
            //        break;
            //    case 'D':
            //        WriteLine("Compra com cartão de débito!");
            //        break;
            //    default:
            //        WriteLine("Compra com dinheiro");
            //        break;
            //}

            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de credito não aprovado!");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de débitonão aprovado!");
                    break;
                default:
                    WriteLine("Compra aprovada");
                    break;
            }

            ReadKey();
        }
    }
}
