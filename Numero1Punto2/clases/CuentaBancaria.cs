namespace clases
{
    internal class CuentaBancaria
    {
        public string Nombre { get; set; }
        public decimal Saldo { get; private set; }
        public decimal LimiteDiario { get; set; }

        public CuentaBancaria(string nombre, decimal saldoInicial, decimal limiteDiario)
        {
            Nombre = nombre;
            Saldo = saldoInicial;
            LimiteDiario = limiteDiario;
        }

        public void Retirar(decimal monto)
        {
            if (monto > LimiteDiario)
            {
                Console.WriteLine("Error: El monto excede el límite diario.");
                return;
            }

            if (monto > Saldo)
            {
                Console.WriteLine("Error: Saldo insuficiente.");
                return;
            }

            Saldo -= monto;
            Console.WriteLine($"Retiro exitoso de {monto}. Nuevo saldo: {Saldo}");
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo actual de {Nombre}: {Saldo}");
        }
    }
}