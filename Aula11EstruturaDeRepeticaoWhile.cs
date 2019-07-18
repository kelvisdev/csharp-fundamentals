using static System.Console;

namespace HelloWorld
{
    class Aula11EstruturaDeRepeticaoWhile
    {
        static void Aula11()
        {
            string[] nomes = new string[3] { "Kelvis", "Bruce", "Fulano" };

            int i = 0;

            while (i <= nomes.Length)
            {
                WriteLine($"Olá {nomes[i]}");
                i++;
            }

            do
            {
                WriteLine($"Olá {nomes[i]}");
                i++;
            } while (i <= 10);

            //while (i <= 10)
            //{
            //    WriteLine($"Num => {i}");
            //    i++;
            //}

            ReadKey();

        }
    }
}
