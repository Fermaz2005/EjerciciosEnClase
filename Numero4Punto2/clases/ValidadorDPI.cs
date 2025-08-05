using System;

namespace Numero4Punto2.clases
{
    public class ValidadorDPI : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 13 && dato.All(char.IsDigit);
        }
    }
}