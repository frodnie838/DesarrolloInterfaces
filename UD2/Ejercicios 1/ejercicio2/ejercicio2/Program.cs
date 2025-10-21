using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double precioHam = 12.00;
            const double precioPat = 3.50;
            const double precioBeb = 2.50;
            Console.WriteLine("------Precios-------");
            Console.WriteLine("Hamburguesas: " + precioHam + "$");
            Console.WriteLine("Patatas: " + precioPat + "$");
            Console.WriteLine("Bebidas: " + precioBeb + "$");
            Console.WriteLine(("-------------------"));

            Console.WriteLine("Indica número de hamburguesas:");            
            int ham = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica número de patatas:");
            int pat = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica número de bebidas");
            int beb = int.Parse(Console.ReadLine());

            double precioFinal = (ham *  precioHam) + (pat * precioPat) + (beb * precioBeb);
            Console.WriteLine("Hamburguesas: " + ham + " - " + (ham*precioHam) + "$");
            Console.WriteLine("Patatas: " + pat + " - " + (pat*precioPat)+"$");
            Console.WriteLine("Bebidas: " + beb + " - " + (beb*precioBeb)+"$");
            Console.WriteLine("Total a pagar: " + precioFinal + "$");
        }
    }
}
