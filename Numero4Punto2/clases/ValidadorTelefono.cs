using System;

namespace Numero4Punto2.clases
{
    public class ValidadorTelefono : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 8 && dato.All(char.IsDigit);
        }
    }
}