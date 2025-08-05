using System;

namespace Numero3Punto2.clases
{
    public class ReproducirMusica : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Reproduciendo música...");
        }
    }
}