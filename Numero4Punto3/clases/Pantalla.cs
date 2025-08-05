using System;

namespace Numero4Punto3.clases
{
    public class Pantalla : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}