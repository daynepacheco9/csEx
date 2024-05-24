using System;
namespace MaiorIdade
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você pode votar e é maior de idade.");
            }
            else if (idade >= 16)
            {
                Console.WriteLine("Você pode votar, mas ainda não é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você não pode votar e não é maior de idade.");
            }
        }
    }
}
