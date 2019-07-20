using static System.Console;

namespace IniciandoComCsharp
{
    class Aula18Classes
    {
        static void Aula18()
        {
            Carro carro = new Carro();
            carro.Marca = "Civic";
            carro.AnoFabricacao = 1978;

            WriteLine($"Eu tenho um {carro.Marca} fabricado em {carro.AnoFabricacao}");

            carro.buzinar();
            carro.virar("D");
            carro.virar("E");

            ReadLine();
        }
    }

    public class Carro
    {
        private string _marca;
        public string Marca
        {
            // C# 7.0
            get => _marca;
            set => _marca = value.Equals("Fusca") ? "Outro Carro" : value;

            // C# 6.0
            //get { return _marca; }
            //set { _marca = value }
        }

        private int _anoFabricacao;
        public int AnoFabricacao
        {
            get => _anoFabricacao;
            set => _anoFabricacao = value;
        }

        public void buzinar()
        {
            WriteLine("bii bii!");
        }

        public void virar(string direcao)
        {
            if (direcao.Equals("D"))
            {
                WriteLine("Virando a direita... ");
            }
            else
            {
                WriteLine("Virando a esquerda...");
            }
        }
    }
}
