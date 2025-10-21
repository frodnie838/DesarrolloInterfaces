using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio4
{
    internal class Program
    {
        public static bool primo(int num)
        {
            bool primo = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                }
            }
            return primo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());
            if (primo(num)) { Console.WriteLine("Es Primo"); }
            else
            {
                Console.WriteLine("No es primo");
            }

        }
        
    }
}
