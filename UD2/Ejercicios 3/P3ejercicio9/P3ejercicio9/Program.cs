using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {6,2,5,0,1,8};
            Console.WriteLine("El menor es: " + lista[menor(lista)]+" en la posición "+menor(lista));
        }

        public static int menor(int[] lista)
        {
            int menor = lista[0];
            int posicion = 0;
            for (int i = 0 ; i < lista.Length ; i++) 
            { 
                if(lista[i] < menor) 
                { 
                    menor = lista[i];
                    posicion = i;
                }
            }
            return posicion;
        }
    }
}
