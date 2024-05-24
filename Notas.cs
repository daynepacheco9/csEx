using System;
namespace Notas
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }
    }
}

