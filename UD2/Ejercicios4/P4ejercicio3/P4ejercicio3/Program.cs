using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4ejercicio3
{
    class Cancion
    {
        private string titulo;
        private string autor;
        
        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public Cancion() {
            this.titulo = titulo;
            this.autor = autor;
        }

        public void dameTitulo()
        {
            Console.WriteLine(titulo);
        }
        public void dameAutor()
        {
            Console.WriteLine(autor);
        }
        public void ponTitulo(string titu)
        {
            titulo = titu;
            Console.WriteLine("Titulo introducido");
        }
        public void ponAutor(string aut)
        {
            autor = aut;
            Console.WriteLine("Autor introducido");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Rosas","Jose");
            Cancion cancion2 = new Cancion();
            Console.WriteLine("Cancion 1");
            cancion1.dameTitulo();
            cancion1.dameAutor();

            Console.WriteLine("Introducción de parámetros de Cancion 2");
            cancion2.ponTitulo("Luna");
            cancion2.ponAutor("Pepe");

            Console.WriteLine("Cancion 2");
            cancion2.dameTitulo();
            cancion2.dameAutor();

        }
    }
}
