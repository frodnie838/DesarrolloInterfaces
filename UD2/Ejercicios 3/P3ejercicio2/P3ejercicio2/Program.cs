using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cadena de texto: ");
            string cadena = Console.ReadLine();             
            Console.WriteLine(blanco(cadena));
        }
        public static int blanco (string cadena)
        {

            int total = 0;
            char caracter = ' ';

            foreach (char c in cadena)
            {
                if (c  == caracter)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
