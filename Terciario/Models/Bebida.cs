using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terciario.Models
{
    class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
    
        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad; 
        }
        public Bebida(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
        public Bebida() { }
        public void tomarse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }
}
