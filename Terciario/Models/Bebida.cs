using System;

namespace Terciario.Models
{
    class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public Bebida() { }

        public void Tomarse(int cuantoBebio)
        {
            Cantidad -= cuantoBebio;
            /*
            if (cuantoBebio > 0 && cuantoBebio <= Cantidad)
                Cantidad -= cuantoBebio;
            else
                Console.WriteLine("La cantidad a beber es inválida o excede la cantidad disponible.");
            */
        }
    }
}
