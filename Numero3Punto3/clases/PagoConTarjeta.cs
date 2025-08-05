using System;

namespace Numero3Punto3.clases
{
    public class PagoConTarjeta : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con tarjeta...");
        }
    }
}