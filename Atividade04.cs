using System;

namespace atividades
{
    public class ex04
    {
        static void Main(string[] args)
        {
        // DESENVOLVA UM PROGRAMA QUE CALCULE O VOLUME DA ESFERA

            Console.Write("Digite o diâmetro: ");
            double diametro = double.Parse(Console.ReadLine());

            double raio = diametro / 2;
            double volume = 4 * 3.1415 * Math.Pow(raio, 3) / 3;

            Console.WriteLine($"O volume da esfera é {volume}");
        }
    }
}
