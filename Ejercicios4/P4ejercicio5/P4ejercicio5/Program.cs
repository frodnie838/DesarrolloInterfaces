using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4ejercicio5
{
    public class Juego
    {
        public int vidas;

        public Juego(int vidas)
        {
            this.vidas = vidas;
        }
        public void MuestraVidasRestantes() 
        {             
            Console.WriteLine("Vidas restantes: "+vidas);
        }
        public void PierdeVida() 
        {
            if (vidas > 0)
            {
                vidas--;
            }
            else
            {
                Console.WriteLine("No te quedan vidas");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego(5);
            juego.MuestraVidasRestantes();
            juego.PierdeVida();
            juego.MuestraVidasRestantes();
            Juego juego2 = new Juego(5);
            juego2.MuestraVidasRestantes();
            juego.MuestraVidasRestantes();
        }
    }
}
