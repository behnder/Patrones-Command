using System;

namespace Patrones_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Accion accionABC = new Accion();

            ComprarAccion comprarAccion = new ComprarAccion(accionABC);
            VenderAccion venderAccion = new VenderAccion(accionABC);

            Broker broker = new Broker();
            broker.TomarOrden(comprarAccion);
            broker.TomarOrden(venderAccion);

            broker.HacerOrden();
        }
    }
}
