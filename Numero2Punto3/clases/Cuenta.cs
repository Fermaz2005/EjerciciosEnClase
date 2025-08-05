using System;

namespace Numero2Punto3.clases
{
    public class Cuenta
    {
        public decimal Saldo { get; protected set; } = 0;

        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine($"Se depositaron Q{cantidad}. Saldo actual: Q{Saldo}");
        }

        public virtual void CalcularIntereses()
        {
            Console.WriteLine("Este método debe ser sobrescrito en las clases hijas.");
        }
    }
}