using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] desorden = { 8, 5, 0, 1, 4, 2, 7, 3, 9, 6 };
            System.Array.Sort(desorden);
            for (int i = 0; i < desorden.Length; i++)
            {
                Console.Write(desorden[i]+" ");
            }
        }
    }
}
