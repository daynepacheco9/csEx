using System;
namespace BomDia
{
    class Program
    {
        static void Main()
        {
            Console.Write("Está chovendo? (sim/nao): ");
            string chovendoResposta = Console.ReadLine().ToLower();

            Console.Write("Está ensolarado? (sim/nao): ");
            string ensolaradoResposta = Console.ReadLine().ToLower();

            bool estaChovendo = chovendoResposta == "sim";
            bool estaEnsolarado = ensolaradoResposta == "sim";

            if (!estaChovendo && estaEnsolarado)
            {
                Console.WriteLine("É um bom dia para sair de casa.");
            }
            else
            {
                Console.WriteLine("Não é um bom dia para sair de casa.");
            }
        }
    }
}

