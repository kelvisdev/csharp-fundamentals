using static System.Console;

namespace IniciandoComCsharp
{
    class Aula03TipoDeDados
    {
        static void Aula3 ()
        {
            char status = 'A';
            int idade = 30;
            WriteLine(status.GetType());
            WriteLine(idade.GetType());

            WriteLine(idade.GetType().IsPrimitive);

            int n1 = 10;
            long n2 = n1;
            short n3 = (short)n1;

            WriteLine(n2);
            WriteLine(n3);
            ReadKey();
        }
    }
}
