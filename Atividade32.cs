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
            // Desenvolva um programa que receba números aleatoriamente enquanto a soma dos números digitados é menor que 100 e exibir a soma dos números digitados
            double userData, sum = 0;
            try
            {
                do
                {
                    Console.Write("Digite um número: ");
                    userData = double.Parse(Console.ReadLine());
                    sum += userData;
                } while (sum < 100);
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"A soma entre os números digitados é: {sum}");
            Console.ReadKey();
        }
    }
}
