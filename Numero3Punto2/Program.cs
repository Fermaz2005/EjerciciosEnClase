using System;
using System.Collections.Generic;
using Numero3Punto2.clases;

namespace Numero3Punto2
{
    class Program
    {
        static void EjecutarComandos(List<ComandoVoz> comandos)
        {
            foreach (var comando in comandos)
            {
                comando.Ejecutar();
            }
        }

        static void Main()
        {
            var comandos = new List<ComandoVoz>
            {
                new EncenderLuces(),
                new ReproducirMusica(),
                new MostrarClima()
            };

            EjecutarComandos(comandos);

            Console.ReadLine();
        }
    }
}