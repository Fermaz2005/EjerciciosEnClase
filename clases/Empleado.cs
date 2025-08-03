using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEnClase1.clases
{
    public class Empleado
    {
        private string _nombre = "";
        private decimal _salario;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _nombre = value;
                else
                    Console.WriteLine("El nombre no puede estar en blanco.");
            }
        }

        public decimal Salario
        {
            get { return _salario; }
            set
            {
                if (value >= 0)
                    _salario = value;
                else
                    Console.WriteLine("El salario no puede ser negativo.");
            }
        }
    }
}