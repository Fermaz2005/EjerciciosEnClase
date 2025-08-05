using System;
using System.Collections.Generic;
using EjerciciosEnClase4.clases;

namespace EjerciciosEnClase4
{
    class Program
    {
        static void Main()
        {
            List<ArchivoMultimedia> archivos = new List<ArchivoMultimedia>
            {
                new Video(),
                new Cancion(),
                new AudioLibro()
            };

            foreach (var archivo in archivos)
            {
                archivo.Reproducir();
            }

            Console.ReadLine();
        }
    }
}