using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculoDivisao
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public void Divisao(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;

            if (Valor2 != 0)
            {
                Console.WriteLine($"O resultado da divisão é {(Valor1 / Valor2)}");
            }
            else
            {
                Console.WriteLine("Não podemos dividir por zero");
            }
        }
    }
}
