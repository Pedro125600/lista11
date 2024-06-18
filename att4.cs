using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cor do peão:");
            string cor = Console.ReadLine();
            Console.WriteLine("Digite o número para identificar o peão:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();





            Jogador jogador = new Jogador(cor,id,nome);

            Console.WriteLine($"Jogador: {jogador.Cor} ");

            while(jogador.Peoes[1] < 10 && jogador.Peoes[0] < 10 && jogador.Peoes[2] < 10 && jogador.Peoes[3] < 10)
            {
                Console.WriteLine($"Escolha um peão para mover o jogo para se todos passarem de 10 casas");

                Console.WriteLine();

                int m = jogador.LancarDado();

                Console.WriteLine($"O peão irá mover {m} casas");

                Console.WriteLine($"Peão 1 : {jogador.Peoes[0]}");
                Console.WriteLine($"Peão 2 : {jogador.Peoes[1]}");
                Console.WriteLine($"Peão 3 : {jogador.Peoes[2]}");
                Console.WriteLine($"Peão 4 : {jogador.Peoes[3]}");

                Console.WriteLine("Escolha um peão para mover");
                int p = int.Parse(Console.ReadLine());

                jogador.MoverPeao(p - 1, m);

                Console.WriteLine($"O Peão {p} esta agora na casa {jogador.Peoes[p-1]}");

            }

            Console.ReadLine();
        }

    }

    public class Jogador
    {
        public string Cor { get; set; }
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public int[] Peoes { get; set; }

        public Jogador(string cor, int identificador, string nome)
        {
            Cor = cor;
            Identificador = identificador;
            Nome = nome;
            Peoes = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Peoes[i] = 0;
            }
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