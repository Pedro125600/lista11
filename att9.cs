using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargo Programador = new Cargo(1, 1.200);
            Cargo Faxineiro = new Cargo(2,200);
            Cargo Professor = new Cargo(3, 2.200);


            Funcionario F1 = new Funcionario(Programador, 'M', 8);
            Funcionario F2 = new Funcionario(Faxineiro, 'F', 6);
            Funcionario F3 = new Funcionario(Professor, 'M', 4);



            Console.WriteLine($"Funcionario 1 : Programador");
            Console.WriteLine($"Sexo {F1.Sexo}");
            Console.WriteLine($"Quantidades de horas trabalhadas : {F1.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salario Final :{F1.CalcularSalarioFinal()}");
            Console.WriteLine();
            Console.WriteLine($"Funcionario 2 : Faxineiro");
            Console.WriteLine($"Sexo {F2.Sexo}");
            Console.WriteLine($"Quantidades de horas trabalhadas : {F2.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salario Final :{F2.CalcularSalarioFinal()}");
            Console.WriteLine();
            Console.WriteLine($"Funcionario 3 : Professor ");
            Console.WriteLine($"Sexo {F3.Sexo}");
            Console.WriteLine($"Quantidades de horas trabalhadas : {F3.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salario Final :{F2.CalcularSalarioFinal()}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class Cargo
    {
        private int codigodocargo;
        private double valordahoratrabalhada;

        public Cargo(int codigodocargo, double valordahoratrabalhada)
        {
            this.codigodocargo = codigodocargo;
            this.valordahoratrabalhada = valordahoratrabalhada;
        }

        public int Codigo { get { return codigodocargo; } set { this.codigodocargo = value; } }
        public double Valor { get { return valordahoratrabalhada; } set { this.valordahoratrabalhada = value; } }
    }

     class Funcionario
    {
       
        private Cargo cargo;
        private char sexo;
        private double quantidadeHorasTrabalhadas;

        public Funcionario(Cargo cargo, char sexo, double quantidadeHorasTrabalhadas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.quantidadeHorasTrabalhadas = quantidadeHorasTrabalhadas;
        }

        public Cargo CargoFuncionario { get { return cargo; } set { cargo = value; } }
        public char Sexo { get { return sexo;} set { sexo = value; } }

        public double QuantidadeHorasTrabalhadas { get { return quantidadeHorasTrabalhadas; } set { quantidadeHorasTrabalhadas = value; } }


        public double CalcularSalarioFinal()
        {
            double salarioFinal = this.CargoFuncionario.Valor * quantidadeHorasTrabalhadas;
            return salarioFinal;
        }

    }
}
