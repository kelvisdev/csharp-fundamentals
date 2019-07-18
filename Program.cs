using static System.Console;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                WriteLine($"Num => {i}");
            }

            string[] nomes = new string[3] { "Kelvis", "Bruce", "Fulano" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i == 1) break;

                WriteLine($"Olá {nomes[i]}");
            }

            ReadKey();
        }
    }
}
