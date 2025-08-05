using System;
using System.Text.RegularExpressions;

namespace Numero4Punto2.clases
{
    public class ValidadorEmail : IValidador
    {
        public bool EsValido(string dato)
        {
            return Regex.IsMatch(dato, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}