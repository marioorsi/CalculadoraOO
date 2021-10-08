using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculoMultiplicacao
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public void Multiplicacao()
        {
            Console.WriteLine($"O resultado da multiplicacao é {(Valor1 * Valor2)}");
        }
    }
}
