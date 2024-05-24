using System;
namespace Triplo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            double triplo = numero * 3;

            Console.WriteLine("O triplo de " + numero + " é: " + triplo);
        }
    }
}

