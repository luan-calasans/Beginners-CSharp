using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex39
    {
        static void Main(string[] args)
        {
            // Fazer um programa que receba valores aleatoriamente enquanto a soma dos números digitas for menor que 100. Após a digitação, exibir:
            // a. O maior valor;
            // b. A soma dos valores;
            // c. A média aritmética dos valores;
            double count = 0, value, highestValue = 0, sum = 0, average = 0;
            try
            {
                while (sum < 100)
                {
                    Console.Write("Digite apenas números menores que 100: ");
                    value = double.Parse(Console.ReadLine());
                    count++;
                    sum += value;
                    average = sum / count;
                    if (value > highestValue)
                    {
                        highestValue = value;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números menores que 100!");
                return;
            }
            Console.Write($"Maior valor = {highestValue}\nSoma dos valores = {sum.ToString("F")}\nMédia dos valores = {average.ToString("F")}");
            Console.ReadKey();
        }
    }
}
