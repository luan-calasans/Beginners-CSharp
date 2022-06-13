using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ex54
    {
        static void Main(string[] args)
        {
            /*             
                Criar um vetor A com 10 elementos inteiros. Escrever um programa que calcule e escreva: 
                a) a soma de elementos armazenados neste vetor que são inferiores a 15; 
                b) a quantidade de elementos armazenados no vetor que são iguais a 15; 
                c) a média dos elementos armazenados no vetor que são superiores a 15.
            */
            int[] number = new int[10];
            int equal15 = 0, sum = 0;
            double average, higher15 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                number[i] = int.Parse(Console.ReadLine());
                while(number[i] < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("ERRO! ");
                    Console.ForegroundColor = ConsoleColor.Gray; Console.Write("Digite um número inteiro positivo: ");
                    number[i] = int.Parse(Console.ReadLine());
                }
                if (number[i] < 15)
                {
                    sum += number[i];
                }
                if (number[i] == 15)
                {
                    equal15++;
                }
                if (number[i] > 15)
                {
                    higher15++;
                }
            }
            average15 = higher15 / number.Length;
            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Soma dos elementos inferiores a 15: {sum}\nQuantidade de elementos iguais a 15: {equal15}\nMédia dos elementos superiores a 15: {average15}");
            Console.ReadKey();
        }
    }
}
