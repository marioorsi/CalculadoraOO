using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class LerDados
    {
        public decimal Ler()
        {
            Console.WriteLine("informe o valor");
            var valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O Valor Informado foi {valor}");
            return valor;
        }
    }
}
