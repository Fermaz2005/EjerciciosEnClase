using System;

namespace EjerciciosEnClase3.clases
{
    public class NotificacionEmail : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando correo electrónico...");
        }
    }
}