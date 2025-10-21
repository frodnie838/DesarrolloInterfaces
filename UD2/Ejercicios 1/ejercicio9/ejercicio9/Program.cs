using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca cadena: ");
            string cadena = Console.ReadLine();
            bool si = false;
            if (cadena.StartsWith("www"))
            {
                si = true;
                Console.WriteLine(si);
            }
            else Console.WriteLine(si);
        }
    }
}
