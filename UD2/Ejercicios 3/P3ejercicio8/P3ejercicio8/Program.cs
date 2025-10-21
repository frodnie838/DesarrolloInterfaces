using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un numero mínimo de dos cifras: ");
            int num = int.Parse(Console.ReadLine());
            while(pedirNumero(num) == false)
            {
                Console.WriteLine("Error.Ingrese un numero mínimo de dos cifras: ");
                num = int.Parse(Console.ReadLine());
            }
                        
            Console.WriteLine("La suma de las cifras del numero es: " + total(num));


        }
        public static int total(int num)
        {
            int total = 0;
            foreach (char c in num.ToString())
            {
                total += int.Parse(c.ToString());
            }
            return total;
        }
        public static bool pedirNumero(int num)
        {
            if(num < 10)
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}
