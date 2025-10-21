using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ejercicio10
{
    // Clase de cliente del banco
    class Cliente
    {
        private string nombre;
        private double cantidadTotal;
        //constructor de la clase 
        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }
        //metodo para ingresar dinero
        public void ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }else
            {
                Console.WriteLine("Cantidad incorreccta");
            }            
        }
        //metodo para sacar dinero
        public void sacar(double cantidad)
        {
            if (cantidad <= cantidadTotal)
            {
                cantidadTotal -= cantidad;
            }else
            {
                Console.WriteLine("Cantidad a retirar no disponible");
            }
        }
        //metodo para obtener la cantidad total
        public double getCantidadTotal()
        {
            return cantidadTotal;
        }
        //metodo para mostrar la informacion del cliente
        public void mostrarInfo()
        {
            Console.WriteLine(nombre + " tiene " + cantidadTotal + " Euros");
        }

    }
    // Clase banco que maneja varios clientes
    class Banco
    {
        Cliente cliente1 = new Cliente("Ana");
        Cliente cliente2 = new Cliente("Pepe");
        Cliente cliente3 = new Cliente("Rosa");
        //metodo para operar con los clientes
        public void operar()
        {
            cliente1.ingresar(5000);
            cliente2.ingresar(1000);
            cliente3.ingresar(50);

            cliente1.sacar(500);
        }
        //metodo para mostrar el estado del banco
        public void mostrarEstado()
        {
            double total = cliente1.getCantidadTotal()+cliente2.getCantidadTotal()+cliente3.getCantidadTotal();
            Console.WriteLine("El total del dinero del banco es " + total);
            cliente1.mostrarInfo();
            cliente2.mostrarInfo();
            cliente3.mostrarInfo();
        }
    }
    internal class Program
    {        
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.operar();
            banco.mostrarEstado();
        }
    }
}
