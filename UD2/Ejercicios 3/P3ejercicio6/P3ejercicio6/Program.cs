using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio6
{
    internal class Program
    {
        public static bool Login(string usu, string pass)
        {
            string usuario = "usuario2DAM";
            string contra = "pass2DAM";
            if (usu.Equals(usuario) && pass.Equals(contra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int intentos = 2;
            while (true)
            {
                Console.WriteLine("Introduce usuario: ");
                string usu = Console.ReadLine();
                Console.WriteLine("Introduce contraseña: ");
                string pass = Console.ReadLine();

                

                if (intentos > 0 && Login(usu, pass) == true)
                {
                    Console.WriteLine("Bienvenido!");
                    break;
                }
                else
                {
                    if (intentos > 0 && Login(usu, pass) == false)
                    {
                        Console.WriteLine("Te quedan " + intentos);
                        intentos -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Limite de intentos");
                        break;
                    }
                }
            }


        }
    }
}
