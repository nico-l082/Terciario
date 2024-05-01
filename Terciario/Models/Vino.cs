﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terciario.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        /*
        public Vino(int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
            
        }
       */
        public Vino(string Nombre, int Cantidad) : base(Nombre, Cantidad)
        {

        }
        public int Alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de vinos es de dos botellas por persona");
        }

     
    }
}
