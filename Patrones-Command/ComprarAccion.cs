using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Command
{
    class ComprarAccion : Orden
    {
        private Accion AccionABC;

        public ComprarAccion(Accion AccionABC)
        {
            this.AccionABC = AccionABC;
        }

        public void Ejecutar()
        {
            AccionABC.comprar();
        }

       
    }
}
