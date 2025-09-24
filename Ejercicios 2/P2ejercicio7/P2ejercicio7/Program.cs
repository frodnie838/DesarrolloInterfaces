using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique longitud del array: ");
            int cant = int.Parse(Console.ReadLine());

            int[] numeros = new int[cant];
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Introduzca numero "+(i+1)+":");
                numeros[i] = int.Parse(Console.ReadLine());
                
            }
            Console.Write("Pares: ");
            for (int i = 0; i < cant; i++)
            {                
                if (numeros[i] % 2 == 0 )
                {
                    Console.Write(numeros[i] +" ");
                }                
            }            
            Console.Write("\nImpares: ");
            for (int i = 0; i < cant; i++)
            {
                
                if (numeros[i] % 2 != 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
        }
    }
}
