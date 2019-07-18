using static System.Console;


namespace HelloWorld
{
    class Aula02Variaveis
    {
        static void Aula2() {
            int idade = 30;
            string nome = "Fulano Silva";
            bool ativo = false;
            decimal salario = 1345.98m;
            float descontos = 397.99f;

            WriteLine($"O usuario {nome} tem {idade} anos de idade, está {ativo} no sistema e ganhha {salario}");
            WriteLine("\n-------------------------------------------------------------------------------------\n");

            dynamic x = "Essa variável é uma string";
            WriteLine(x);
            x = 10;
            WriteLine(x);
            x = true;
            WriteLine(x);
            ReadKey();
        }
    }
}
