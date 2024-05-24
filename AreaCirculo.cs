using System;
namespace AreaCirculo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo com raio " + raio + " é: " + area);
        }
    }
}

