using System;

namespace ALTURA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura (centímetros): ");
            int A = int.Parse(Console.ReadLine());

            if (A <= 160)
            {
                Console.WriteLine("Você é baixo(a)");
            }
            else
            {
                if (A >= 170 && A <= 175)
                {
                    Console.WriteLine("Sua altura é mediana");
                }
                else
                {
                    Console.WriteLine("Você é alto(a)");
                }
            }
            Console.ReadKey();
        }
    }
}
