using System;
using Terciario.Models;

namespace Terciario
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida();
            Bebida bebida2 = new Bebida("fanta", 600);

            bebida.Nombre = "Coquita";
            bebida.Cantidad = 500;

            bebida.Tomarse(100);
            bebida2.Tomarse(200);

            Console.WriteLine("Le quedan " + bebida.Cantidad + " a la bebida: " + bebida.Nombre);
            Console.WriteLine(bebida2.Cantidad);
        }
    }
}