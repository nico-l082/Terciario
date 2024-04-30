using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terciario.Models
{
    internal class Vino : Bebida
    {   
        /*
        public Vino(int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
            
        }
       */
        public Vino(string Nombre, int Cantidad) : base(Nombre, Cantidad)
        {

        }
    }
}
