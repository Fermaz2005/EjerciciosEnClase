using System;
using System.Collections.Generic;
using Numero4Punto2.clases;

namespace Numero4Punto2
{
    class Program
    {
        static void Main()
        {
            List<IValidador> validadores = new List<IValidador>
            {
                new ValidadorEmail(),
                new ValidadorTelefono(),
                new ValidadorDPI()
            };

            string[] datos = { "test@correo.com", "51234567", "1234567890101", "correo", "888" };

            foreach (var dato in datos)
            {
                Console.WriteLine($"\nProbando dato: {dato}");
                foreach (var validador in validadores)
                {
                    Console.WriteLine($"- {validador.GetType().Name}: {(validador.EsValido(dato) ? "Válido" : "Inválido")}");
                }
            }

            Console.ReadLine();
        }
    }
}