using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace IniciandoComCsharp
{
    public class Veiculo
    {
        private string _marca;
        public string Marca
        {
            // C# 7.0
            get => _marca;
            set => _marca = value;

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

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Gilson");
            arrayList.Add(32);
            arrayList.Add(new object());

            List<string> dias = new List<string>();
            dias.Add("Dom");
            dias.Add("Seg");
            dias.Add("Ter");
            dias.Add("Qua");
            dias.Add("Qui");
            dias.Add("Sex");
            dias.Add("Sab");

            //foreach (string dia in dias)
            //{
            //    WriteLine(dia);
            //}

            List<Veiculo> veiculos = new List<Veiculo>();

            Veiculo carro = new Veiculo();
            carro.Marca = "Civic";
            carro.AnoFabricacao = 2019;
            veiculos.Add(carro);

            Veiculo carro1 = new Veiculo();
            carro1.Marca = "Fusca";
            carro1.AnoFabricacao = 1978;
            veiculos.Add(carro1);

            Veiculo carro2 = new Veiculo();
            carro2.Marca = "Mustang";
            carro2.AnoFabricacao = 1980;
            veiculos.Add(carro2);

            foreach (Veiculo veiculo in veiculos)
            {
                WriteLine($"Eu tenho um {veiculo.Marca} fabricado em {veiculo.AnoFabricacao}");
            }

            ReadLine();
        }
    }
}
