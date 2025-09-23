using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca tercer número: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca cuarto número: ");
            double num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");
            Console.WriteLine("La suma de " + num1 + " y " + num2 + " es " + (num1 + num2));
            Console.WriteLine("El producto de "+num3+ " y " +num4+ " es " + (num3 * num4));

        }
    }
}
