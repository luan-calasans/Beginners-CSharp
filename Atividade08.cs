using System;

namespace atividades
{
    public class ex08
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE O VALOR DA TENSÃO

            Console.Write("Digite o valor da resistência: ");
            double resistencia = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da corrente: ");
            double corrente = double.Parse(Console.ReadLine());

            double tensao = resistencia * corrente;

            Console.WriteLine($"O valor da tensão é {tensao}");
        }
    }
}
