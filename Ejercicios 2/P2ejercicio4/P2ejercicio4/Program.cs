using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número por teclado: ");
            int numero = int.Parse(Console.ReadLine());
            int fact = numero;
            Console.Write(numero);
            for (int i = 1; i < numero; i++)
            {
                Console.Write(" * " + i);
                fact *= i;
            }
            Console.Write(" = "+fact);
        }
    }
}
