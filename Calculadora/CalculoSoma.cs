using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculoSoma
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public void Soma(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;

            Console.WriteLine($"O resultado da soma é {(Valor1 + Valor2)}");
        }
    }
}
