using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indica nota examen 1: ");
            double exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indica nota examen 2: ");
            double exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indica nota trabajos en clase: ");
            double clase = double.Parse(Console.ReadLine());
            Console.WriteLine("Indica nota de actitud: ");
            double actitud = double.Parse(Console.ReadLine());

            double Fexamenes = ((exam1 + exam2) / 2) * 0.5;
            double Fclase = clase * 0.3;
            double Factitud = actitud * 0.2;
            double final = Fexamenes + Fclase + Factitud;

            Console.WriteLine("Nota final: " + final);
        }
    }
}
