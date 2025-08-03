using System;
using EjerciciosEnClase1.clases;

class Program
{
    static void Main(string[] args)
    {
        Empleado emp = new Empleado();

        emp.Nombre = "Luis";
        emp.Salario = 5000;

        Console.WriteLine($"Nombre: {emp.Nombre}");
        Console.WriteLine($"Salario: {emp.Salario}");


        emp.Nombre = "";       
        emp.Salario = -1000;

        Console.ReadKey();
    }
}