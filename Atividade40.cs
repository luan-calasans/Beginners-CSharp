using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex40
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que receba 10 valores via teclado e depois exiba:
               - Quantidade de números < 30
               - Soma dos valores > 100
               - Média dos demais
             */
            double userData, count = 0, sum = 0, average = 0, underThirty = 0, sumHundred = 0;
            try
            {
                while (count < 10)
                {
                    Console.Write("Digite um valor: ");
                    userData = double.Parse(Console.ReadLine());
                    count++;
                    sum += userData;
                    average = sum / count;
                    if (userData < 30)
                    {
                        underThirty++;
                    }
                    if (userData > 100)
                    {
                        sumHundred += userData;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.Write($"Quantidade de números < 30: {underThirty}\nSoma dos valores > 100: {sumHundred}\nMédia dos demais: {average}");
            Console.ReadKey();
        }
    }
}
