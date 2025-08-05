using System;

namespace EjerciciosEnClase3.clases
{
    public class NotificacionSMS : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS...");
        }
    }
}