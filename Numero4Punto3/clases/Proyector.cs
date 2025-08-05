using System;

namespace Numero4Punto3.clases
{
    public class Proyector : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Lanzando proyección: {mensaje}");
        }
    }
}