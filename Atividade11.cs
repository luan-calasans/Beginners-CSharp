using System;

namespace atividades
{
    public class ex11
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE EXIBA O MAIOR ENTRE TRÊS NÚMEROS DIGITADOS VIA TECLADO
            Console.WriteLine("========================");
            Console.WriteLine("QUAL É O MAIOR NÚMERO?");
            Console.WriteLine("========================");
            
            Console.Write("Digite o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o terceiro número: ");
            double z = double.Parse(Console.ReadLine());
            
            if (x>y && x>z)
            {
                Console.WriteLine($"O maior número é: {x}");
            }
            else
            {
                if (y>x && y>z)
                {
                    Console.WriteLine($"O maior número é: {y}");
                }
                else
                {
                    if (z>x && z>y)
                    {
                        Console.WriteLine($"O maior número é: {z}");
                    }
                    else
                    {
                        Console.WriteLine("Os três números são iguais");
                    }
                }
            }
        }
    }
}
