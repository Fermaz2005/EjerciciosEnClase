using System;

namespace Numero4Punto3.clases
{
    public class Impresora : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Imprimiendo mensaje: {mensaje}");
        }
    }
}