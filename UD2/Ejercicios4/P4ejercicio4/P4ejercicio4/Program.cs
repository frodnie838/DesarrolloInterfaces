using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4ejercicio4
{
    public class Cancion
    {
        private string titulo;
        private string autor;

        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public Cancion()
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public string ToString()
        {
            return titulo + " - " + autor;
        }
    }

    public class CD
    {
        private Cancion[] canciones;
        private int contador;

        public CD()
        {
            canciones = new Cancion[10];
            contador = 0;
        }

        public void NumeroCanciones()
        {
            Console.WriteLine("Número de canciones en el CD: " + contador);            
        }

        public Cancion DameCancion(int posicion)
        {
            if (posicion < 0 || posicion >= contador)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Canción en la posición " + posicion + ": Título - " + canciones[posicion].ToString());
                return canciones[posicion];
            }
        }

        public void GrabaCancion(int posicion, Cancion cancion)
        {
            if (posicion < 0 || posicion >= canciones.Length)
            {
                Console.WriteLine("Posicion no valida");
            }
            else
            {
                if (posicion >= contador)
                {
                    Console.WriteLine("No hay canción en esa posición para reemplazar.");
                }
                else
                {
                    canciones[posicion] = cancion;
                }
            }
        }

        public void Agrega(Cancion cancion)
        {
            if (contador < canciones.Length)
            {
                canciones[contador] = cancion;
                contador++;
            }
            else
            {
                Console.WriteLine("No hay espacio para más canciones.");
            }
        }

        public void Elimina(int posicion)
        {
            if (posicion < 0 || posicion >= contador)
            {
                Console.WriteLine("Posicion no valida");
            }
            else
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    canciones[i] = canciones[i + 1];
                }
                canciones[contador - 1] = null;
                contador--;
            }
        }

        public void Canciones()
        {
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Canción " + (i + 1) + ": " + canciones[i].ToString());
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.NumeroCanciones();
            Cancion cancion1 = new Cancion("Rosas", "Pepe");
            cd.Agrega(cancion1);
            Cancion cancion2 = new Cancion("La Flaca", "Jarabe de Palo");
            cd.Agrega(cancion2);
            cd.Canciones();
            cd.NumeroCanciones();
            cd.DameCancion(1);
            cd.Elimina(0);
            cd.NumeroCanciones();            
            Cancion cancion3 = new Cancion("Corazón Espinado", "Santana");
            cd.GrabaCancion(0, cancion3);                        
            cd.Canciones();
        }
    }
}
