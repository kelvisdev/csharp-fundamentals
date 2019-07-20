using System;
using static System.Console;

namespace IniciandoComCsharp
{
    public struct Cliente
    {
        public int matricula;
        public string nome;
        public string email;

        public void digaOi()
        {
            WriteLine($"oi {this.nome}");
        }
    }

    class Aula21Structs
    {
        static void Aula21()
        {
            Cliente cliente = new Cliente();
            cliente.matricula = 123;
            cliente.nome = "Kelvis Borges";
            cliente.email = "kb@gmail.com";

            cliente.digaOi();

            ReadLine();
        }        
    }
}
