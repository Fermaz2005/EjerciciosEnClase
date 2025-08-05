using System;
using EjerciciosEnClase2.clases;

namespace EjerciciosEnClase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado
            {
                Nombre = "Carlos",
                Salario = 2500.50m
            };

            Console.WriteLine($"Empleado: {empleado.Nombre}, Salario: Q{empleado.Salario}");

            Gerente gerente = new Gerente();
            gerente.TomarDecision();

            Desarrollador desarrollador = new Desarrollador();
            desarrollador.Programar();

            Console.ReadLine();
        }
    }
}