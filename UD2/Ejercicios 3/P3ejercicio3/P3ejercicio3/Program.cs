using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("El factorial de "+num + " es "+ factorial(num));
        }
        public static double factorial(double num)
        {

            if (num == 0) {
                return 1;
            }
            else 
            {
                return num * factorial(num - 1);
            }
        }
    }
}
