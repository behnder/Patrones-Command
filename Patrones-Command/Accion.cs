using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Command
{
    public class Accion
    {
        private String nombre = "ABC";
        private int cantidad = 10;

        public void comprar()
        {
            Console.WriteLine("Acción [ Nombre: " + nombre + ", Cantidad: " + cantidad +" ]  comprada");
        }
        public void vender()
        {
            Console.WriteLine("Acción [ Nombre: " + nombre + ", Cantidad: " + cantidad + " ]  vendida");
        }
    }
}
