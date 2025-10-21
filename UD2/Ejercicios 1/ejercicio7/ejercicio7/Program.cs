using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indica precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Indica cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Total a pagar: " + (cantidad * precio) +"$");
        }
    }
}
