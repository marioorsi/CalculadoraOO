using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Cabecalho
    {
        public static void Mensagem()
        {
            Console.Clear();
            Console.WriteLine("Calculadora - Desafio 01");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Opções:  1 - Somar");
            Console.WriteLine("         2 - Subtrair");
            Console.WriteLine("         3 - Multiplicar");
            Console.WriteLine("         4 - Dividir");
            Console.WriteLine("        99 - Sair");
        }
    }
}
