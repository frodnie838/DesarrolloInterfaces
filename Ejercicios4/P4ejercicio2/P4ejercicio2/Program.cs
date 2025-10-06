using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4ejercicio2
{
    class Contacto
    {
        private string nombre;
        private double telefono;
        public Contacto(string nombre, double telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public string getNombre()
        {
            return nombre;
        }
        public double getTelefono()
        {
            return telefono;
        }
    }

    class agenda
    {
        private List<Contacto> contactos;
        public agenda()
        {
            contactos = new List<Contacto>(10);
        }
        public void agregarContacto(Contacto contacto)
        {
            if (contactos.Count >= 10)
            {
                Console.WriteLine("La agenda esta llena");
                return;
            }
            foreach (Contacto c in contactos)
            {
                if (existeContacto(contacto))
                {
                    Console.WriteLine("El contacto ya existe");
                    return;
                }
            }
            contactos.Add(contacto);
        }
        public bool existeContacto(Contacto contacto)
        {
            foreach (Contacto c in contactos)
            {
                if (c.getNombre() == contacto.getNombre())
                {
                    return true;
                }
            }
            return false;
        }
        public void listarContactos()
        {
            foreach (Contacto c in contactos)
            {
                Console.WriteLine("Nombre: " + c.getNombre() + " Telefono: " + c.getTelefono());
            }
        }
        public void buscarContacto(string nombre)
        {
            foreach (Contacto c in contactos)
            {
                if (c.getNombre() == nombre)
                {
                    Console.WriteLine("Nombre: " + c.getNombre() + " Telefono: " + c.getTelefono());
                    return;
                }
            }
            Console.WriteLine("El contacto no existe");
        }
        public void eliminarContacto(string nombre)
        {
            for (int i = 0; i < contactos.Count; i++)
            {
                if (contactos[i].getNombre() == nombre)
                {
                    contactos.RemoveAt(i);
                    Console.WriteLine("Contacto eliminado");
                    return;
                }
            }
            Console.WriteLine("El contacto no existe");
        }
        public void agendaLlena()
        {
            if (contactos.Count >= 10)
            {
                Console.WriteLine("La agenda esta llena");
            }
            else
            {
                Console.WriteLine("La agenda no esta llena");
            }
        }
        public void huecosLibres()
        {
            Console.WriteLine("Huecos libres: " + (10 - contactos.Count));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            agenda miAgenda = new agenda();
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú Agenda ---");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. ¿Agenda llena?");
                Console.WriteLine("6. Mostrar huecos libres");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        double telefono;
                        if (!double.TryParse(Console.ReadLine(), out telefono))
                        {
                            Console.WriteLine("Teléfono no válido.");
                            break;
                        }
                        miAgenda.agregarContacto(new Contacto(nombre, telefono));
                        break;
                    case 2:
                        miAgenda.listarContactos();
                        break;
                    case 3:
                        Console.Write("Nombre a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        miAgenda.buscarContacto(nombreBuscar);
                        break;
                    case 4:
                        Console.Write("Nombre a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        miAgenda.eliminarContacto(nombreEliminar);
                        break;
                    case 5:
                        miAgenda.agendaLlena();
                        break;
                    case 6:
                        miAgenda.huecosLibres();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
    
}
