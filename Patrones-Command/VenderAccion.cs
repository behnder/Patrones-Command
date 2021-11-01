using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Command
{
    class VenderAccion : Orden
    {
        private Accion abcAccion;

        public VenderAccion(Accion abcAccion)
        {
            this.abcAccion = abcAccion;
        }

        public void Ejecutar()
        {
            abcAccion.vender();
        }
    }
}
