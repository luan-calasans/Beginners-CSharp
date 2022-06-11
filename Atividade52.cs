using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex03
{
    internal class C37461_ListaVetores_ex03
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Implementar um programa
                que defina e escreva a média aritmética simples dos elementos ímpares
                armazenados neste vetor.
             */
            int[] numeroInteiro = new int[10];
            double mediaAritmetica, armazenaImpar = 0;
            for (int i = 0; i < 10; i++)
            {
                numeroInteiro[i] = i;
                if (numeroInteiro[i] % 2 != 0)
                {
                    armazenaImpar++;
                }
                Console.WriteLine($"Número inteiro: {numeroInteiro[i]}");
            }
            mediaAritmetica = armazenaImpar / numeroInteiro.Length;
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"A média dos número ímpares é: {mediaAritmetica}");
            Console.ReadKey();
        }
    }
}
