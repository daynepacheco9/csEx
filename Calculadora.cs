using System;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite o número da operação desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado da Soma: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado da Subtração: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado da Multiplicação: " + resultado);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                        Console.WriteLine("Resultado da Divisão: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    operacaoValida = false;
                    Console.WriteLine("Erro: Operação inválida.");
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine("Operação realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Por favor, execute o programa novamente e escolha uma operação válida.");
            }
        }
    }
}

