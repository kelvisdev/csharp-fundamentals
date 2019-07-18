using System.Collections.Generic;
using static System.Console;

namespace HelloWorld
{
    class Aula06EstruturaDeDadosPilha
    {
        static void Aula06()
        {
            Stack<int> p1 = new Stack<int>();

            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);

            WriteLine(p1.ToArray().GetValue(0));
            WriteLine(p1.ToArray().GetValue(1));
            WriteLine(p1.ToArray().GetValue(2));
            WriteLine(p1.ToArray().GetValue(3));
            WriteLine(p1.ToArray().GetValue(4));
            WriteLine($"A pilha tem {p1.Count} itens.");

            p1.Pop();

            WriteLine(p1.ToArray().GetValue(3));
            WriteLine($"A pilha tem {p1.Count} itens.");

            WriteLine($"Qual vai ser retirado naquele momento/Ultimo elemento adicionado {p1.Peek()}.");

            p1.Clear();
            WriteLine($"A pilha tem {p1.Count} itens.");

            ReadKey();
        }
    }
}
