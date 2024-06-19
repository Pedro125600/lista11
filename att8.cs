using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quer passar salario ? S ou N");

            char resp = char.Parse(Console.ReadLine());

            if(resp == 'S')
            {
                Console.WriteLine("Escreva o nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva o cargo");
                string cargo = Console.ReadLine();
                Console.WriteLine("Escreva o salario");
                int salario = int.Parse(Console.ReadLine());

                Funcionario f = new Funcionario(nome, cargo, salario);



                Console.WriteLine($"Nome {f.Nome}");
                Console.WriteLine($"Cargo {f.Cargo}");
                Console.WriteLine($"Salario {f.Salario}");
            }
            else
            {
                Console.WriteLine("Escreva o nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva o cargo");
                string cargo = Console.ReadLine();


                Funcionario f = new Funcionario(nome, cargo);



                Console.WriteLine($"Nome {f.Salario}");
                Console.WriteLine($"Cargo {f.Cargo}");
                Console.WriteLine($"Salario {f.Salario}");
            }











            Console.ReadLine();
        }


        class Funcionario
        {
            private string nome;
            private string cargo;
            private double salario;

            public Funcionario(string nome, string cargo, double salario)
            {

                this.nome = nome;
                this.cargo = cargo;
                this.salario = salario;
            }

            public Funcionario(string nome, string cargo)
            {

                this.nome = nome;
                this.cargo = cargo;
                this.salario = 4500.0;

        
            }


            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public string Cargo
            {
                get { return cargo; }
                set { cargo = value; }
            }

            public double Salario
            {
                get { return salario; }
                set { salario = value; }
            }

      
           
        }
    }
}
