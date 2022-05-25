using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex41
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que receba 10 valores via teclado e depois exiba:
               - Quantidade de números < 30
               - Soma dos valores > 100
               - Média dos demais
               E no final perguntar para o usuário se deseja refazer o programa
             */
            double userData, count = 0, sum = 0, average = 0, under30 = 0, sum100 = 0;
            string answer;
            try
            {
                while (count < 10)
                {
                    Console.Write("Digite um valor: ");
                    userData = double.Parse(Console.ReadLine());
                    count++;
                    sum += userData;
                    average = sum / count;
                    if (userData < 30)
                    {
                        under30++;
                    }
                    if (userData > 100)
                    {
                        sum100 += userData;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.Write($"Quantidade de números < 30: {under30}\nSoma dos valores > 100: {sum100}\nMédia dos demais: {average}");
            Console.Write("\n=======================");
            Console.Write("\nDigite\n[R] Refazer programa\n[E] Encerrar programa\n");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            switch (answer)
            {
                case "R":
                    userData = 0; count = 0; sum = 0; average = 0; under30 = 0; sum100 = 0;
                    try
                    {
                        Console.Clear();
                        while (count < 10)
                        {
                            Console.Write("Digite um valor: ");
                            userData = double.Parse(Console.ReadLine());
                            count++;
                            sum += userData;
                            average = sum / count;
                            if (userData < 30)
                            {
                                under30++;
                            }
                            if (userData > 100)
                            {
                                sum100 += userData;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas números!");
                        Console.ReadKey();
                        return;
                    }
                    Console.Write($"Quantidade de números < 30: {under30}\nSoma dos valores > 100: {sum100}\nMédia dos demais: {average}");
                    break;

                case "E":
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Você digitou outro caractere, encerrando...");
                    break;
            }
            Console.ReadKey();
        }
    }
}
