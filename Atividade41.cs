using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade 
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
            double dadoUsuario, contagem = 0, soma = 0, media = 0, menorTrinta = 0, somaCem = 0;
            string resposta;
            try
            {
                while (contagem < 10)
                {
                    Console.Write("Digite um valor: ");
                    dadoUsuario = double.Parse(Console.ReadLine());
                    contagem++;
                    soma += dadoUsuario;
                    media = soma / contagem;
                    if (dadoUsuario < 30)
                    {
                        menorTrinta++;
                    }
                    if (dadoUsuario > 100)
                    {
                        somaCem += dadoUsuario;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
                return;
            }
            Console.Write($"Quantidade de números < 30: {menorTrinta}\nSoma dos valores > 100: {somaCem}\nMédia dos demais: {media}");
            Console.Write("\n=======================");
            Console.Write("\nDigite\n[R] Refazer programa\n[E] Encerrar programa\n");
            resposta = Console.ReadLine();
            resposta = resposta.ToUpper();
            switch (resposta)
            {
                case "R":
                    dadoUsuario = 0; contagem = 0; soma = 0; media = 0; menorTrinta = 0; somaCem = 0;
                    try
                    {
                        while (contagem < 10)
                        {
                            Console.Write("Digite um valor: ");
                            dadoUsuario = double.Parse(Console.ReadLine());
                            contagem++;
                            soma += dadoUsuario;
                            media = soma / contagem;
                            if (dadoUsuario < 30)
                            {
                                menorTrinta++;
                            }
                            if (dadoUsuario > 100)
                            {
                                somaCem += dadoUsuario;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas números!");
                        Console.ReadKey();
                        return;
                    }
                    Console.Write($"Quantidade de números < 30: {menorTrinta}\nSoma dos valores > 100: {somaCem}\nMédia dos demais: {media}");
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