using clases;

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Luis", 5000, 1000);

        cuenta.MostrarSaldo();
        cuenta.Retirar(1500);
        cuenta.Retirar(800);
        cuenta.MostrarSaldo();
    }
}