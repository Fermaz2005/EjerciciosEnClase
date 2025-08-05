using System;

namespace Numero2Punto3.clases
{
    public class CuentaCorriente : Cuenta
    {
        public override void CalcularIntereses()
        {
            decimal interes = Saldo * 0.02m;
            Console.WriteLine($"Interés en Cuenta Corriente: Q{interes}");
        }
    }
}