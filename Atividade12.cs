using System;

namespace ORDEM_DECRESCENTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE EXIBA EM ORDEM DESCRESCENTE TRÊS NÚMEROS DIGITADOS VIA TECLADO
            double x, y, z;
            Console.WriteLine("===============================");
            Console.WriteLine("ORDEM DESCRESCENTE -> 3 NÚMEROS");
            Console.WriteLine("===============================");
            Console.Write("Digite o primeiro número: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            z = double.Parse(Console.ReadLine());
            if (x > y)
            {
                if (y > z)
                {
                    Console.WriteLine($"A ordem decrescente é: {x} > {y} > {z}");
                }
                else
                {
                    if (z > x)
                    {
                        Console.WriteLine($"A ordem decrescente é: {z} > {x} > {y}");
                    }
                    else
                    {
                        Console.WriteLine($"A ordem decrescente é: {x} > {z} > {y}");
                    }
                }
            }
            else
            {
                if (x > z)
                {
                    Console.WriteLine($"A ordem decrescente é: {y} > {x} > {z}");
                }
                else
                {
                    if (z > y)
                    {
                        Console.WriteLine($"A ordem descrescente é: {z} > {y} > {x}");
                    }
                    else
                    {
                        Console.WriteLine($"A ordem descrescente é: {y} > {z} > {x}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
