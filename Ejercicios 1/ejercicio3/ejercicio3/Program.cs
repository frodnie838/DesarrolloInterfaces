using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("Potencia al cubo: " + (num * 3));
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Número máximo entre 5 y " + num + ": " + Math.Max(5, num));
            Console.WriteLine("Número mínimo entre 5 y " + num + ": " + Math.Min(5, num));

        }
    }
}
