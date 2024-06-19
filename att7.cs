using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque 50 clientes");


            Cliente[] c = new Cliente[5];


            for (int i = 0; i < 5 ;i++)
            {
                Console.WriteLine($"Cliente {i + 1}");

                Console.WriteLine("Escreva o nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva o endereço ");
                string endereco = Console.ReadLine();
                Console.WriteLine("Escreva o telefone");
                int tel = int.Parse(Console.ReadLine());


                c[i] = new Cliente(nome, endereco, tel);


            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Cliente {i + 1}");
                Cliente cliente = c[i];
                Console.WriteLine($"Cliente {cliente.Nome} registrado com o endereco {cliente.Endereco} e o Telefone {cliente.Tel}");
                Console.WriteLine();

            }


            Console.ReadLine();


        }

    }



    class Cliente
    {
        private string nome;
        private string endereco;
        private int tel;

        public Cliente(string nome, string endereco, int tel)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.tel = tel;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public int Tel { get { return tel; } set { tel = value; } }

    }
}
