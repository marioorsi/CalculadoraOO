using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculoSubtracao
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public void Subtracao()
        {
            Console.WriteLine($"O resultado da subtração é {(Valor1 - Valor2)}");
        }
    }
}
