using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> stack = new Stack<int>();
            Console.WriteLine("introduce numeros a apilar:");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("introduce numero: ");
                int num = int.Parse(Console.ReadLine());
                stack.Push(num);
            }

            Console.WriteLine("Valores de la pila: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sacando elementos:");
            stack.Pop();            
            stack.Pop();
            Console.WriteLine("Valores de la pila: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
