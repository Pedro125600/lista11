using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva o endereço ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Escreva o telefone");
            int tel = int.Parse(Console.ReadLine());

            Cliente c = new Cliente(nome, endereco, tel);

            Console.WriteLine($"Cliente {c.Nome} registrado com o endereco {c.Endereco} e o Telefone {c.Tel}");
            Console.ReadLine();


        }

    }



   class Cliente
    {
        private string nome;
        private string endereco;
        private int tel;

        public Cliente(string nome , string endereco , int tel)
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
