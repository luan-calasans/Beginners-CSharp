using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desenvolva um programa que receba números aleatoriamente enquanto a soma dos números digitados é menor que 100 e exibir a média entre eles
            double userData, avg = 0, sum = 0, count = 0;
            try
            {
                while (sum < 100)
                {
                    Console.Write("Digite um número: ");
                    userData = double.Parse(Console.ReadLine());
                    sum += userData;
                    count++;
                    avg = sum / count;
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números:");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"A média entre os números digitados é {avg}");
            Console.ReadKey();  
        }
    }
}
