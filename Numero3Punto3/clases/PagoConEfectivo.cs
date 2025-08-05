using System;

namespace Numero3Punto3.clases
{
    public class PagoConEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Recibiendo efectivo...");
        }
    }
}