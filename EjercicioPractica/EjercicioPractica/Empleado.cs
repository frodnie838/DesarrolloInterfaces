using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioPractica
{
    internal class Empleado
    {
        public string nombre;
        public double salario;
        public double horasExtra;
        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.horasExtra = 0;
        }
        public bool InsertarHoraExtra(double horas)
        {
            if (horas <= 0) 
            {
                Console.WriteLine("No se puede añadir 0 horas o número de horas en negativo");
                return false;
            }
            else 
            {
                horasExtra += horas;
                return true;
            }
                
        }

        public double CalcularSalarioTotal()
        {
            return salario + (horasExtra * 25);
        }

    }
}
