using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
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
            Console.WriteLine("La suma de " + num1 + " más " + num2 + " más " + num3 + " más " + num4 + " es " + (num1 + num2+num3+num4));
            Console.WriteLine("El promedio de " + num1 + " , " + num2+ " , " + num3 + " , " + num4 + " es " + ((num1 + num2 + num3 + num4)/4));

        }
    }
}
