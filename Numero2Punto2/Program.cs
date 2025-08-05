using System;
using Numero2Punto2.clases;

namespace Numero2Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Avanzar();
            auto.EncenderRadio();

            Console.WriteLine();

            Motocicleta moto = new Motocicleta();
            moto.Avanzar();
            moto.HacerCaballito();

            Console.ReadLine();
        }
    }
}