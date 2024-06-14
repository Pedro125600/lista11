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
        {

            Console.WriteLine("De a cor do peão:");
            string cor = Console.ReadLine();
            Console.WriteLine("De o numero para identificar o peão o peão:");
             int id = int.Parse(Console.ReadLine());

            Peao p = new Peao(cor, id);

            string resp = "S";

            while (resp == "S")
            {
                Console.WriteLine($"Peão:{p.Identificador} Cor:{p.Cor} Posição:{p.Posicao}");

                Console.WriteLine("Mover = M , s");
                resp = Console.ReadLine();
                if (resp == "S" )
                {

                    Random r = new Random();

                    int m = r.Next(10);

                    p.Mover(m);
                }
           


            }





        }
           


        }
    }


    class Peao
    {
        private string cor;
        private int identificador;
        private int posicao;

        public Peao(string cor, int indentificador)
        {
            this.cor = cor;
            this.identificador = indentificador;
            this.posicao = 0;
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public  int Identificador
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
            this.Posicao += m;
        }

        public void RetornarCasa(int m)
        {
            this.Posicao -= m;
        }


    }
   

