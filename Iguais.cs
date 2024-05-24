using System;
namespace Iguais
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números são diferentes.");
            }
        }
    }
}
