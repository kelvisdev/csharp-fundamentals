using static System.Console;

namespace IniciandoComCsharp
{
    class Aula04Operadores
    {
        static void Aula04()
        {
            var x = 10;
            var y = 5;

            var soma = x + y;
            var subtrair = x - y;
            var multiplicar = x * y;
            var dividir = x / y;

            var resto = 7 % 3;

            WriteLine(soma);
            WriteLine(subtrair);
            WriteLine(multiplicar);
            WriteLine(dividir);

            WriteLine(resto);

            ReadKey();
        }
    }
}
