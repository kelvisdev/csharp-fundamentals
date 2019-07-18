using static System.Console;

namespace HelloWorld
{
    class Aula05Arrays
    {
        static void Aula5()
        {
            int a = 10;
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 15;
            WriteLine(x[1]);

            string[] nomes = new string[2];
            nomes[0] = "Elvis";
            nomes[1] = "João";
            WriteLine(nomes[0]);
            WriteLine(nomes[1]);

            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            WriteLine(diasSemanas[3]);

            ReadKey();
        }
    }
}
