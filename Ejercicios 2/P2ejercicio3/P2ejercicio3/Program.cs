using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca texto:");
            String texto = Console.ReadLine();

            Console.WriteLine("Mayúscaula: "+texto.ToUpper());
            Console.WriteLine("Minúscula: "+texto.ToLower());
            Console.WriteLine("La longitud del texto es "+texto.Length);
            Console.WriteLine("Reemplazar letra 'o' por 'a': " + texto.Replace('o','a'));
            Console.WriteLine("Primer y último carácter: "+texto.First()+" "+texto.Last());
            Console.WriteLine("Eliminamos la segunda letra: "+texto.Remove(1,1));
            Console.WriteLine("Nos quedamos con la segunda y tercera letra : " + texto.Substring(1, 2));

        }
    }
}
