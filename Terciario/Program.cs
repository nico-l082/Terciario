using System;
using Terciario.Models;

namespace Terciario
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------

            //Vectores - Arrays
            int[] array = new int[5] {1, 2, 3, 4, 5};
            int num = array[0];
            Console.WriteLine("---------------------------------");

            Console.WriteLine(num);
            Console.WriteLine(array.Length);

            Console.WriteLine("---------------------------------");
            //Forma 1 para recorrer un vector de la forma tradicional.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Iteracion: " + i + " - " + array[i]);
            }

            Console.WriteLine("---------------------------------");

            //Forma 2 de recorrer un vector con foreach.
            foreach (var numeros in array)
            {
                Console.WriteLine(numeros);
            }

            //-------------------------------------------------------------------------------------------

            Bebida bebida = new Bebida();
            Bebida bebida2 = new Bebida("fanta", 600);

            bebida.Nombre = "Coquita";
            bebida.Cantidad = 500;

            bebida.Tomarse(100);
            bebida2.Tomarse(200);

            Console.WriteLine("Le quedan " + bebida.Cantidad + " a la bebida: " + bebida.Nombre);
            Console.WriteLine(bebida2.Cantidad);

            Console.WriteLine("---------------------------------");

            //-------------------------------------------------------------------------------------------
            //Herencia de la clase "Bebida" a la clase "Vino".
            //Vino vinoUno = new Vino(50);
            Vino vinoDos = new Vino("Vino", 50);

            vinoDos.Tomarse(10);

            Console.WriteLine(vinoDos.Nombre, vinoDos.Cantidad);
        }
    }
}