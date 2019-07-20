using System.Collections;
using static System.Console;

namespace IniciandoComCsharp
{
    class Aula07EstruturaDeDadosFila
    {
        static void Aula7()
        {
            Queue fila = new Queue();
            fila.Enqueue("João");
            fila.Enqueue("Amanda");
            fila.Enqueue("Maria");
            fila.Enqueue("Tony Stark");

            WriteLine($"Qual vai ser retirado naquele momento? {fila.Peek()}.");

            WriteLine($"A FILA tem {fila.Count} itens.");

            WriteLine($"O item {fila.Dequeue()} foi retirado");
            WriteLine($"A FILA tem {fila.Count} itens.");

            WriteLine($"O item {fila.Dequeue()} foi retirado");
            WriteLine($"A FILA tem {fila.Count} itens.");

            ReadKey();
        }
    }
}
