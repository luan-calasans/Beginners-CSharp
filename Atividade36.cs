using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex36
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com o sexo de determinado usuário, aceitar somente “F” ou “M” como respostas válidas.
            string gender;
            try
            {
                Console.Write("'F' para feminino 'M' para masculino\nDigite seu gênero: ");
                gender = Console.ReadLine();
                do
                {
                    Console.WriteLine("Digite apenas 'F' ou 'M'");
                    Console.Write("Digite seu gênero: ");
                    gender = Console.ReadLine();
                } while (gender != "F" && gender != "M");

                if (gender == "M")
                {
                    Console.Write("Seu gênero é Masculino!");
                }
                else 
                {
                    Console.Write("Seu gênero é Feminino!");
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas 'F' ou 'M'");
                return;
            }
            Console.ReadKey();
        }
    }
}
