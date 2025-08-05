using System;

namespace EjerciciosEnClase3.clases
{
    public class NotificacionPush : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificación push...");
        }
    }
}