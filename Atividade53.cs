using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex04
{
    internal class C37461_ListaVetores_ex04
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Desenvolver um programa
                que defina o percentual de elementos pares e ímpares, respectivamente,
                armazenados neste vetor.
             */
            int[] numeroInteiro = new int[10];
            double armazenaPar = 0, armazenaImpar = 0, percentualPar, percentualImpar;
            for (int i = 0; i < 10; i++)
            {
                numeroInteiro[i] = i;
                if (numeroInteiro[i] % 2 == 0)
                {
                    armazenaPar++;
                }
                else
                {
                    armazenaImpar++;
                }
                Console.WriteLine($"Número inteiro: {numeroInteiro[i]}");
            }

            percentualPar = (armazenaPar * 100) / numeroInteiro.Length;
            percentualImpar = (armazenaImpar * 100) / numeroInteiro.Length;

            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Percentual de números pares: {percentualPar}%\nPercentual de números ímpares: {percentualImpar}%");
            Console.ReadKey();
        }
    }
}
