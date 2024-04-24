using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terciario.Models;

namespace Terciario
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida();
            Bebida bebida2 = new Bebida("fanta", 600);

            bebida.SetNombre("Coquita");
            bebida.SetCantidad(500);
     
            bebida.tomarse(100);
            bebida2.tomarse(200);

            Console.WriteLine("Le quedan " + bebida.cantidad + " a la bebida: " + bebida.nombre);
            Console.WriteLine(bebida2.cantidad);
        }
    }
}
