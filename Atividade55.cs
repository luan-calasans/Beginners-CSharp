using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex07
{
    internal class C37461_ListaVetores_ex07
    {
        static void Main(string[] args)
        {
            /* Ler 10 elementos inteiros em um vetor A. Montar uma rotina de busca, 
               para pesquisar se um dado elemento X esta armazenado em A. */
            int contador = 1, numeroPesquisado;
            int[] numeroInteiro = new int[10];
            int[] numeroDigitado = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{contador}º número: " );
                numeroDigitado[i] = int.Parse(Console.ReadLine());
                contador++;
            }

            Console.Write("Digite um número a ser pesquisado: ");
            numeroPesquisado = int.Parse(Console.ReadLine());
            
            if (numeroDigitado[9] == numeroPesquisado || numeroDigitado[8] == numeroPesquisado || numeroDigitado[7] == numeroPesquisado || numeroDigitado[6] == numeroPesquisado || numeroDigitado[5] == numeroPesquisado || numeroDigitado[4] == numeroPesquisado || numeroDigitado[3] == numeroPesquisado || numeroDigitado[2] == numeroPesquisado || numeroDigitado[1] == numeroPesquisado || numeroDigitado[0] == numeroPesquisado)
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
