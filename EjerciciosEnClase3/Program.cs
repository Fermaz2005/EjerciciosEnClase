using System;
using System.Collections.Generic;
using EjerciciosEnClase3.clases;

namespace EjerciciosEnClase3
{
    class Program
    {
        static void Main()
        {
            List<Notificacion> notificaciones = new List<Notificacion>
            {
                new NotificacionEmail(),
                new NotificacionSMS(),
                new NotificacionPush()
            };

            foreach (var noti in notificaciones)
            {
                noti.Enviar();
            }

            Console.ReadLine();
        }
    }
}