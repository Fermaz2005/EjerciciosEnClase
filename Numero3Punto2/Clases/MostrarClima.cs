using System;

namespace Numero3Punto2.clases
{
    public class MostrarClima : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Mostrando clima actual...");
        }
    }
}