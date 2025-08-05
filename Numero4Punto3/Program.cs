using System;
using System.Collections.Generic;
using Numero4Punto3.clases;

namespace Numero4Punto3
{
    class Program
    {
        static void Main()
        {
            List<DispositivoSalida> dispositivos = new List<DispositivoSalida>
            {
                new Pantalla(),
                new Proyector(),
                new Impresora()
            };

            foreach (var dispositivo in dispositivos)
            {
                dispositivo.MostrarMensaje("Hola, mundo.");
            }

            Console.ReadLine();
        }
    }
}