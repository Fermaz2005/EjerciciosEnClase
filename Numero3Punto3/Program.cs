using System;
using System.Collections.Generic;
using Numero3Punto3.clases;

namespace Numero3Punto3
{
    class Program
    {
        static void Main()
        {
            List<Pago> pagos = new List<Pago>
            {
                new PagoConTarjeta(),
                new PagoConEfectivo(),
                new PagoConTransferencia()
            };

            foreach (var pago in pagos)
            {
                pago.ProcesarPago();
            }

            Console.ReadLine();
        }
    }
}