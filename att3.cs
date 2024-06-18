using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
          Console.WriteLine("Digite a cor do peão:");
            string cor = Console.ReadLine();
            Console.WriteLine("Digite o número para identificar o peão:");
            int id = int.Parse(Console.ReadLine());

            Peao p = new Peao(cor, id);

            string resp = "A";
            Random r = new Random();

            while (resp != "S")
            {
                Console.WriteLine();
                Console.WriteLine($"Peão:{p.Identificador} Cor:{p.Cor} Posição:{p.Posicao}");

                int m = r.Next(1,10); 

                Console.WriteLine($"O peão irá mover {m} casas");

                Console.WriteLine("Mover = M , Retornar = R , Sair = S");
                resp = Console.ReadLine().ToUpper();

                switch (resp)
                {
                    case "M":
                        p.Mover(m);
                        break;
                    case "R":
                        p.RetornarCasa(m);
                        break;
                    case "S":
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            Console.WriteLine($"Peão:{p.Identificador} Cor:{p.Cor} Posição:{p.Posicao}");
            Console.ReadLine();
        }

        class Peao
        {
            private string cor;
            private int identificador;
            private int posicao;

            public Peao(string cor, int identificador)
            {
                this.cor = cor;
                this.identificador = identificador;
                this.posicao = 0;
            }

            public string Cor
            {
                get { return cor; }
                set { cor = value; }
            }

            public int Identificador
            {
                get { return identificador; }
                set { identificador = value; }
            }

            public int Posicao
            {
                get { return posicao; }
                set { posicao = value; }
            }

            public void Mover(int m)
            {
                posicao += m;
            }

            public void RetornarCasa(int m)
            {
                posicao -= m;
            }
        }
    }
}
