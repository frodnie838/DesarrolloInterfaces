using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduzca tamaño del array: ");
            int tama = int.Parse(Console.ReadLine());
            int[] array = new int[tama];
            int suma = 0;
            for (int i = 0; i < tama; i++)
            {
                Console.Write("Introduce valor " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                suma += array[i];
            }
            Console.WriteLine("La suma del array es "+suma);
            Console.WriteLine("La media del array es "+(suma/tama));

        }
    }
}
