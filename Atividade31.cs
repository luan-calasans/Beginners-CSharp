using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex31
    {
        static void Main(string[] args)
        {
            // Desenvolva um progama que receba 10 números via teclado e no final exiba a soma dos nº digitados
            double userData, count = 0, sum = 0;
            try
            {
                while(count<10)
                { 
                    Console.Write("Digite um número: ");
                    userData = double.Parse(Console.ReadLine());
                    sum += userData; // sum = sum + userData;
                    count++;
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"A soma entre eles é igual a {sum}");
            Console.ReadKey();
        }
    }
}
