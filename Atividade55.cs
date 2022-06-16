using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex55
    {
        static void Main(string[] args)
        {
            /* Ler 10 elementos inteiros em um vetor A. Montar uma rotina de busca, 
               para pesquisar se um dado elemento X esta armazenado em A. */
            int count = 1, searchedNumber;
            int[] number = new int[10];
            int[] typedNumber = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{count}º número: " );
                typedNumber[i] = int.Parse(Console.ReadLine());
                count++;
            }

            Console.Write("Digite um número a ser pesquisado: ");
            searchedNumber = int.Parse(Console.ReadLine());
            
            if (typedNumber[9] == searchedNumber || typedNumber[8] == searchedNumber || typedNumber[7] == searchedNumber || typedNumber[6] == searchedNumber || typedNumber[5] == searchedNumber || typedNumber[4] == searchedNumber || typedNumber[3] == searchedNumber || typedNumber[2] == searchedNumber || typedNumber[1] == searchedNumber || typedNumber[0] == searchedNumber)
            {
                Console.Write("O número");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write(" está ");
                Console.ForegroundColor = ConsoleColor.Gray; Console.Write("armazenado no vetor");
            }
            else
            {
                Console.Write("O número");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" não está ");
                Console.ForegroundColor = ConsoleColor.Gray; Console.Write("armazenado no vetor");
            }
            
            Console.ReadKey();

        }
    }
}
