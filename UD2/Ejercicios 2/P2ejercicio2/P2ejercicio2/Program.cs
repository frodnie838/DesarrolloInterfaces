using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique un número del 1 al 9: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 9)
            {
                Console.WriteLine("Número inválido");                
            }else {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numero + " X " + i + " = " + (numero * i));
                }            
            }

        }
    }
}
