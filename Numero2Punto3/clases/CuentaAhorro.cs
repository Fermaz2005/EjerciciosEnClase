using System;

namespace Numero2Punto3.clases
{
    public class CuentaAhorro : Cuenta
    {
        public override void CalcularIntereses()
        {
            decimal interes = Saldo * 0.05m; // 5% de interés
            Console.WriteLine($"Interés en Cuenta Ahorro: Q{interes}");
        }
    }
}