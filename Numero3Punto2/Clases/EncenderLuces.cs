using System;

namespace Numero3Punto2.clases
{
    public class EncenderLuces : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Encendiendo luces...");
        }
    }
}