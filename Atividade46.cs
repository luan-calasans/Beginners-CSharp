using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex46
    {
        static void Main(string[] args)
        {
            /*
                Desenvolva um programa que receba 10 valores via teclado e exiba:
                - Soma
                - Média
                - Maior
                - Ordem de digitação (não importa se é maior ou menor)
             */
            double sum = 0, bigger = 0, average;
            int[] userData = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Digite um valor: ");
                    userData[i] = int.Parse(Console.ReadLine());
                    sum += userData[i];
                    if (userData[i] > bigger)
                    {
                        bigger = userData[i];
                    }
                }
                average = sum / 10;
                Console.WriteLine($"Soma: {sum}\nMédia: {average}\nMaior: {bigger}");
                Console.Write("Ordem:");
                for (int z = 0; z < 10; z++)
                {
                    Console.Write($" {userData[z]}");
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Digite apenas números:");
                Console.ReadKey();
                return;
            }            
        }
    }
}
