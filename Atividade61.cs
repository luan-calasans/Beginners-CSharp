using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividades
{
    class ex61
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int i,j,aux;

            for (i = 0; i < vector.Length; i++)
            {
                Console.Write("{0}º elemento : ", i + 1);
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < vector.Length - 1; i++)
            {
                for (j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {  
                        aux = exchange(vector, i, j);  
                    }
                }
            }

            Console.Clear();

            for (i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("{0}º elemento : {1}", i + 1, vector[i]);
            }

            Console.ReadKey();
        }
        private static int exchange(int[] vector, int i, int j)
        {
            int aux = vector[i];
            vector[i] = vector[j];
            vector[j] = aux;
            return aux;
        }
    }
}
