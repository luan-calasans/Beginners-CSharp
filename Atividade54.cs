using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex05
{
    internal class C37461_ListaVetores_ex05
    {
        static void Main(string[] args)
        {
            /*             
                Criar um vetor A com 10 elementos inteiros. Escrever um programa que calcule e escreva: 
                a) a soma de elementos armazenados neste vetor que são inferiores a 15; 
                b) a quantidade de elementos armazenados no vetor que são iguais a 15; 
                c) a média dos elementos armazenados no vetor que são superiores a 15.
            */
            int[] numeroInteiro = new int[10];
            int quantidadeIgual15 = 0, somaInferior15 = 0;
            double mediaSuperior15, quantidadeSuperior15 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                numeroInteiro[i] = int.Parse(Console.ReadLine());
                while(numeroInteiro[i] < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("ERRO! ");
                    Console.ForegroundColor = ConsoleColor.Gray; Console.Write("Digite um número inteiro positivo: ");
                    numeroInteiro[i] = int.Parse(Console.ReadLine());
                }
                if (numeroInteiro[i] < 15)
                {
                    somaInferior15 += numeroInteiro[i];
                }
                if (numeroInteiro[i] == 15)
                {
                    quantidadeIgual15++;
                }
                if (numeroInteiro[i] > 15)
                {
                    quantidadeSuperior15++;
                }
            }
            mediaSuperior15 = quantidadeSuperior15 / numeroInteiro.Length;
            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Soma dos elementos inferiores a 15: {somaInferior15}\nQuantidade de elementos iguais a 15: {quantidadeIgual15}\nMédia dos elementos superiores a 15: {mediaSuperior15}");
            Console.ReadKey();
        }
    }
}
