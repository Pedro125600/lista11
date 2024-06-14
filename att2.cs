using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De o 1 lado de um triangulo");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("De o 2 lado de um triangulo");
            double l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("De o 3 lado de um triangulo");
            double l3 = double.Parse(Console.ReadLine());

            triangulo t = new triangulo(l1, l2, l3);

            Console.WriteLine($"Lado1 = {t.Lado1} Lado2 = {t.Lado2} Lado3 = {t.Lado3} ");

            triangulo t2 = new triangulo();

            Console.WriteLine($"Lado1 = {t2.Lado1} Lado2 = {t2.Lado2} Lado3 = {t2.Lado3} ");


            Console.ReadLine();
        }
    }


    class triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public triangulo()
        {
            this.lado1 = 123;
            this.lado2 = 123;
            this.lado3 = 123;
        }

      
        public double Lado1 { get { return lado1; } set { lado1 = value; } }
        public double Lado2 { get { return lado2; } set { lado2 = value; } }
        public double Lado3 { get { return lado3; } set { lado3 = value; } }



    }
}
