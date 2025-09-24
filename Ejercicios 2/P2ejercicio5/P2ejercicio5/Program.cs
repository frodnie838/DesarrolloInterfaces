using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mayus;   
            for (char i = 'z'; i >= 'a'; i--)
            {
                mayus = i.ToString().ToUpper();
                Console.Write(mayus+" ");
            }
        }
    }
}
