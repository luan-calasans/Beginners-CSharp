using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex02
{
    internal class C37461_ListaVetores_ex02
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Implementar um programa
                que defina e escreva a soma de todos os elementos armazenados neste
                vetor.  
             */
            int[] numeroInteiro = new int[10];
            int somaInteiros = 0;
            for (int i = 0; i < 10; i++)
            {                
                numeroInteiro[i] = i;
                Console.WriteLine($"Número Inteiro: {numeroInteiro[i]}");
                somaInteiros += numeroInteiro[i];
            }
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"A soma dos números inteiros acima é igual a: {somaInteiros}");
            Console.ReadKey();
        }
    }
}
