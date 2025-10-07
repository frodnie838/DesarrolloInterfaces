using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractica
{
    internal class Program
    {
        protected static ArrayList empleados = new ArrayList();
        protected static int contador = 0;

        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("********************Bienvenidos a OsunaTech S.L.********************");
                Console.WriteLine("ADMINISTRACIÓN");
                Console.WriteLine("1)     Dar de alta nuevo empleado ");
                Console.WriteLine("2)     Calcular horas extra totales de todos los empleados ");
                Console.WriteLine("3)     Mostrar informe de todos los empleados ");
                Console.WriteLine("EMPLEADOS");
                Console.WriteLine("4)     Insertar hora extra");
                Console.WriteLine("5)     Salir");
                Console.WriteLine("********************************************************************");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce el nombre del empleado: ");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Introduce el salario del empleado: ");
                        double salario = double.Parse(Console.ReadLine());
                        try 
                        {
                            DarAlta(nombre, salario);                            
                        }catch (Exception e) 
                        { 
                            Console.WriteLine("Error al crear el empleado: " + e.Message); 
                            break; 
                        }
                        break;
                    case 2:
                        HorasExtra();

                        break;
                    case 3:
                        Informe();

                        break;
                    case 4:
                        Console.WriteLine("Introduce el nombre del empleado: ");
                        String nombreEmp = Console.ReadLine();
                        Console.WriteLine("Introduce las horas extra a insertar: ");
                        double horas = double.Parse(Console.ReadLine());
                        foreach (Empleado emp in empleados)
                        { 
                            if(emp.nombre.ToLower().Equals(nombreEmp.ToLower())) 
                            { 
                                if(emp.InsertarHoraExtra(horas)) 
                                Console.WriteLine("Horas extra insertadas correctamente"); 
                                break; 
                            } 
                            else 
                            { 
                                Console.WriteLine("Empleado no encontrado"); 
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }

        
        }
        public static void DarAlta(String nombre, double salario)
        {
            empleados.Add(new Empleado(nombre, salario));
            contador++;
        }
        public static void HorasExtra()
        {
            double total = 0;
            foreach (Empleado emp in empleados)
            {
                total += emp.horasExtra;
            }

            Console.WriteLine("Horas extras de todos los empleados: " + total + " Horas");
        }
        public static void Informe()
        {
            Console.WriteLine("*************INFORME DE EMPLEADOS***************");
            foreach (Empleado emp in empleados)
            {
                Console.WriteLine("Nombre: " + emp.nombre + " - Salario: " + emp.salario + " - Horas Extra: " + emp.horasExtra + " - Salario Total: " + emp.CalcularSalarioTotal());
            }
        }
    }
}
