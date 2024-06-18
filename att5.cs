using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro();

            while (tab.Peoes[1] < 50 && tab.Peoes[0] < 50 && tab.Peoes[2] < 50 && tab.Peoes[3] < 50)
            {
                Console.WriteLine($"Escolha um peão para mover o jogo para se todos passarem de 10 casas");

                Console.WriteLine();

                int m = tab.LancarDado();

                Console.WriteLine($"O peão irá mover {m} casas");

                Console.WriteLine($"Peão 1 : {tab.Peoes[0]}");
                Console.WriteLine($"Peão 2 : {tab.Peoes[1]}");
                Console.WriteLine($"Peão 3 : {tab.Peoes[2]}");
                Console.WriteLine($"Peão 4 : {tab.Peoes[3]}");

                Console.WriteLine("Escolha um peão para mover");
                int p = int.Parse(Console.ReadLine());

                tab.VerificarCaptura(p - 1);
                tab.VerificarCasaSegura(p - 1);


                tab.MoverPeao(p - 1, m);

                Console.WriteLine($"O Peão {p} esta agora na casa {tab.Peoes[p - 1]}");

            }

            Console.ReadLine();



        }


    }


    class Tabuleiro
    {
       public  int[] Peoes;
       public  int[] Casas;

        public Tabuleiro()
        {
            Peoes = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Peoes[i] = 0;
            }

            Casas = new int[50];
            for (int i = 10; i < 50; i += 10)
            {
                Casas[i] = 51;
            }
        }
        public void VerificarCasaSegura(int i)
        {
            int posicao = Peoes[i];
            if (Casas[posicao] == 51)
            {
                Console.WriteLine($"Peão {i + 1} está em uma casa segura.");
            }
        }

        public void VerificarCaptura(int i)
        {
            int posicao = Peoes[i];
            if (Casas[posicao] != 51 && Casas[posicao] != 0)
            {
                int peaoC= Casas[posicao] - 1;
                if (peaoC != i)
                {
                    Peoes[peaoC] = 0;
                    Console.WriteLine($"Peão {peaoC + 1} foi capturado e voltou para a casa 0.");
                }
            }
            Casas[posicao] = i + 1;
        }
        public int LancarDado()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public void MoverPeao(int i, int m)
        {
            Peoes[i] += m;
        }

    }

}
