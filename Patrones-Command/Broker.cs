using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Command
{
    class Broker
    {
        private List<Orden> ordenes = new List<Orden>();

        public void TomarOrden(Orden orden)
        {
            ordenes.Add(orden);
        }

        public void HacerOrden()
        {
            foreach (Orden orden in ordenes)
            {
                orden.Ejecutar();
            }
            ordenes.Clear();
                
        }

    }
}
