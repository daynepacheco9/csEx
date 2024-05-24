using System;
namespace NumeroMaior
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O primeiro número (" + num1 + ") é maior que o segundo número (" + num2 + ").");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O primeiro número (" + num1 + ") é menor que o segundo número (" + num2 + ").");
            }
            else
            {
                Console.WriteLine("O primeiro número (" + num1 + ") é igual ao segundo número (" + num2 + ").");
            }
        }
    }

}
