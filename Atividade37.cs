using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex37
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com dez valores positivos. Consistir a digitação e enviar mensagem de erro, se necessário. Após a digitação, exibir:
            // a.O maior valor;
            // b.A soma dos valores;
            // c.A média aritmética dos valores.
            double count = 0, value, highestValue = 0, sum = 0, average = 0;
            try
            {
                while (count < 10)
                {
                    Console.Write("Digite apenas números positivos: ");
                    value = double.Parse(Console.ReadLine());
                    if (value < 0)
                    {
                        Console.Write("ERRO!\nDigite apenas números positivos: ");
                        value = double.Parse(Console.ReadLine());
                        if (value > 0)
                        {
                            count++;
                            sum += value;
                            average = sum / count;
                            if (value > highestValue)
                            {
                                highestValue = value;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERRO!");
                        }
                    }
                    else
                    {
                        count++;
                        sum += value;
                        average = sum / count;
                        if (value > highestValue)
                        {
                            highestValue = value;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números positivos!");
                return;
            }
            Console.Write($"Maior valor = {highestValue}\nSoma dos valores = {sum}\nMédia dos valores = {average}");
            Console.ReadKey();
        }
    }
}
