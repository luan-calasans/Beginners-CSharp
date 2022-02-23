using System;
namespace MeuNamespace
{
    public class MinhaAplicacao
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE EXIBA O MAIOR ENTRE DOIS NÚMEROS DIGITADOS

        Console.WriteLine("========================");
        Console.WriteLine("QUAL É O MAIOR NÚMERO?");
        Console.WriteLine("========================");

        Console.Write("Digite um número: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        double y = double.Parse(Console.ReadLine());

        if (x > y)
        {
            Console.WriteLine($"O maior número é: {x}");
        }
        else
        {
            if (x == y)
            {
                Console.WriteLine("Ambos os números são iguais");
            }
            else
            {
                Console.WriteLine($"O maior número é: {y}");
            }
        }

        }
    }
}
