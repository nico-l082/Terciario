using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terciario.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        /*
        public Vino(int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
            
        }
       */
        public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad)
        {
        }
        public Cerveza() { }
        public int Alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de cervezas es de dos birras por persona");
        }


    }
}
