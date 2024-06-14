using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista11
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Console.WriteLine("Nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("matricula");
            int matriculas = int.Parse(Console.ReadLine());

            Random r = new Random();

            double[] notas = new double[50];

            for(int i = 0; i < 50;i++)
            {

                notas[i] = r.Next(0, 11);

            }


            Aluno aluno = new Aluno(nome,matriculas, notas);

            Console.WriteLine($"Aluno:{aluno.Nome} Matricula:{aluno.Matricula} Medias:{aluno.media()} ");

            Console.ReadLine();
        }
    }

    class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas = new double[50] ;

        public string Nome { get { return nome; } set { nome = value; } }
        public int Matricula { get { return matricula; } set { matricula = value; } }

        public double[] Notas { get { return notas; } set { notas = value; } }

        public Aluno(string nome , int matricula , double[] notas  )
        {
            this.notas = notas;
            this.nome = nome;
            this.matricula = matricula;
        }


        public double media()
        {
     
            double total = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];

            }

            return total / notas.Length;
        }

    }


}
