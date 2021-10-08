using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        public int valorTeste { get; set; }
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Cabecalho.Mensagem();

                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Sua opção foi somar\n");
                        soma(LerDados(), LerDados());
                        Retornar();
                        break;

                    case 2:
                        Console.WriteLine("Sua opção foi subtrair\n");
                        subtracao(LerDados(), LerDados());
                        Retornar();
                        break;

                    case 3:
                        Console.WriteLine("Sua opção foi multiplicar\n");
                        multiplicacao(LerDados(), LerDados());
                        Retornar();
                        break;

                    case 4:
                        Console.WriteLine("Sua opção foi dividir\n");
                        divisao(LerDados(), LerDados());
                        Retornar();
                        break;

                    case 99:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Essa opção é inválida");
                        Retornar();
                        break;
                }
            } while (opcao != 99);
        }

        static void soma(decimal valor1, decimal valor2)
        {
            CalculoSoma operacao = new CalculoSoma();
            operacao.Soma(valor1, valor2);
        }

        static void subtracao(decimal valor1, decimal valor2)
        {
            CalculoSubtracao operacao = new CalculoSubtracao();
            operacao.Valor1 = valor1;
            operacao.Valor2 = valor2;
            operacao.Subtracao();
        }

        static void multiplicacao(decimal valor1, decimal valor2)
        {
            CalculoMultiplicacao operacao = new CalculoMultiplicacao();
            operacao.Valor1 = valor1;
            operacao.Valor2 = valor2;
            operacao.Multiplicacao();
        }

        static void divisao(decimal valor1, decimal valor2)
        {
            CalculoDivisao operacao = new CalculoDivisao();
            operacao.Divisao(valor1, valor2);
        }

        static decimal LerDados()
        {
            LerDados teclado = new LerDados();
            return teclado.Ler();
        }

        static void Retornar()
        {
            Console.WriteLine("\nPressione qualquer tecla para retornar à Calculadora");
            Console.ReadLine();
        }
    }
}
