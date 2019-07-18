using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace HelloWorld
{
    class Aula13EstruturaDeRepeticaoForeach
    {
        static void Aula13()
        {
            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };
            foreach (string dia in diasSemanas)
                WriteLine($"Hoje é dia {dia}");

            // Pilha
            Stack<int> p1 = new Stack<int>();
            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);
            foreach (int num in p1)
                WriteLine($"Numero {num}");

            // Fila
            Queue fila = new Queue();
            fila.Enqueue("João");
            fila.Enqueue("Amanda");
            fila.Enqueue("Maria");
            fila.Enqueue("Tony Stark");

            foreach (string nome in fila)
                WriteLine($"Nome -> {nome}");

            ReadKey();
        }
    }
}
