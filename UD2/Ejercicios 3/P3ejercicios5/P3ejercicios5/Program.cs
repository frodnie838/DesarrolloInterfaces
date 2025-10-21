using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicios5
{
    internal class Program
    {
        public static int potenciaRecursiva(int num, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            else if (exp >= 1)
            {

                return num * potenciaRecursiva(num, exp - 1);
            }
            else
            {
                return 1 / potenciaRecursiva(num, exp);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Introduce el número base: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("\nIntroduce el exponente X: ");
            int exp = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + num + " elevado a " + exp + " es igual a " + potenciaRecursiva(num,exp));
            /*
              int total = 1;
              for (int i = 0; i < exp; i++)
              {
                  total *= num;
              }
              Console.WriteLine("\n"+num + " elevado a " + exp + " es igual a " + total);
            */




        }
    }
}
