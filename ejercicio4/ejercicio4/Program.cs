using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el valor del lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine("El perímetro del cuadrado es: " + (lado * 4));
        }
    }
}
