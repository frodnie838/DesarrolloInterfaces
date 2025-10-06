using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4ejercicio1
{
    class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular, double cantidad = 0)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public void Ingresar(double cant)
        {
            if (cant > 0)
            {
                cantidad += cant;
            }
        }
        public void Retirar(double cant)
        {
            if (cant < cantidad)
            {
                cantidad -= cant;
            }else { cantidad = 0; }
        }
        public override string ToString()
        {
            return $"Titular: {titular}, Cantidad: {cantidad}";
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Pepe", 1000);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Ingresar(500);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Retirar(2000);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Retirar(300);
            Console.WriteLine(cuenta1.ToString());
            
            Cuenta cuenta2 = new Cuenta("Ana");
            Console.WriteLine(cuenta2.ToString());
            cuenta2.Ingresar(-200);
            Console.WriteLine(cuenta2.ToString());
            cuenta2.Ingresar(200);
            Console.WriteLine(cuenta2.ToString());
            cuenta2.Retirar(100);
            Console.WriteLine(cuenta2.ToString());
            
        }
    }
}
