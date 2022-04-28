using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex30
    {
        static void Main(string[] args)
        {
            /*
                Desenvolva um programa que receba três números via teclado e no final exiba 
                o maior e o menor. Ps: todas as estruturas idênticas.
             */
            double userData, userData2, smaller, bigger, count = 0;
            try
            {
                Console.Write("Digite um número: ");
                userData = double.Parse(Console.ReadLine());
                smaller = userData;
                bigger = userData;
                while (count < 2)
                {
                    Console.Write("Digite um número: ");
                    userData2 = double.Parse(Console.ReadLine());
                    if (userData2 < smaller)
                    {
                        smaller = userData2;
                    }
                    else if (userData2 > bigger)
                    {
                        bigger = userData2;
                    }
                    count++;
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadLine();
                return;
            }
            Console.Write($"Maior: {bigger}\nMenor: {smaller}");
            Console.ReadKey();
        }
    }
}
