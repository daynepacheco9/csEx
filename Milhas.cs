using System;
namespace Milhas
{
    class Program
    {
        static void Main()
        {
            // Solicita ao usuário que insira a distância em quilômetros
            Console.Write("Digite a distância em quilômetros: ");
            double quilometros = double.Parse(Console.ReadLine());

            // Converte quilômetros para milhas
            double milhas = quilometros * 0.621371;

            // Exibe o resultado
            Console.WriteLine(quilometros + " quilômetros é igual a " + milhas + " milhas.");
        }
    }
}

