using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex45
    {
        static void Main(string[] args)
        {
            /*
                Desenvolva um programa que receba 10 números via teclado e exiba:
                - Maior
                - Soma
                - Média 
             */
            double userData, bigger = 0, sum = 0, average;
            try
            {
                for (int controle = 0; controle < 10; controle++)
                {
                    Console.Write("Digite um número:");
                    userData = double.Parse(Console.ReadLine());
                    if (userData > bigger)
                    {
                        bigger = userData;
                    }
                    sum += userData;
                }
                average = sum / 10;
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Maior: {bigger}\nSoma: {sum}\nMédia: {average}");
            Console.ReadKey();
        }
    }
}
