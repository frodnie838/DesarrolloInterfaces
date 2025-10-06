using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio7
{
    internal class Program
    {
        public static bool multiplo(int num1, int num2) {
            if (num1%num2 == 0)
            {
                return true;
            }else
                return false; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce número 2: ");
            int num2 = int.Parse(Console.ReadLine());
            if (multiplo(num1,num2))
            {
                Console.WriteLine(num1+" Es múltiplo de "+num2);
            }
            else
            {
                Console.WriteLine(num1+" No es múltiplo de "+num2);
            }

        }
    }
}
