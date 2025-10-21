using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indique su estado civil (C/S/V/D):");
            string estado = Console.ReadLine().ToUpper();
            char civil = char.Parse(estado);

            switch (civil)
            {
                case 'C':
                    Console.WriteLine("Usted es Casado");
                    break;
                case 'S':
                    Console.WriteLine("Usted es Soltero");
                    break;
                case 'V':
                    Console.WriteLine("Usted es Viudo");
                    break;
                case 'D':
                    Console.WriteLine("Usted es Divorciado");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
