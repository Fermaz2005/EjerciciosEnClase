using System;
using Numero2Punto3.clases;

namespace Numero2Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro ahorro = new CuentaAhorro();
            ahorro.Depositar(1000);
            ahorro.CalcularIntereses();

            Console.WriteLine();

            CuentaCorriente corriente = new CuentaCorriente();
            corriente.Depositar(2000);
            corriente.CalcularIntereses();

            Console.ReadLine();
        }
    }
}