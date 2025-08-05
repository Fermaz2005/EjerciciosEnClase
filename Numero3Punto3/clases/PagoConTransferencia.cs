using System;

namespace Numero3Punto3.clases
{
    public class PagoConTransferencia : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Iniciando transferencia bancaria...");
        }
    }
}