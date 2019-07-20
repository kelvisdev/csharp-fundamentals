using System;
using static System.Console;

namespace IniciandoComCsharp
{
    class Pessoa
    {
        private string _nome;
        public string Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get => _idade;
            set => _idade = value < 0 || value > 120 ? throw new Exception("Idade Invalida") : value;
        }
    }

    class Aula19UsandoThrowAtributoClasse
    {
        static void Aula19()
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = "Fulano da Silva";
                // pessoa.Idade = 50;
                pessoa.Idade = 150;
                WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            ReadLine();
        }
        
    }
}
