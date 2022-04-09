using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades
{
    internal class ex25
    {
        static void Main(string[] args)
        {
            // Uma escola com cursos em regime semestral realiza duas avaliações durante
            // o semestre e calcula a média do aluno, da seguinte maneira:
            // media = (P1 + (2 * P2))
            // Fazer um programa para entrar via teclado com o valor da primeira nota
            // (P1) e o programa deverá calcular e exibir quanto o aluno precisa tirar
            // na segunda nota(P2) para ser aprovado, sabendo que a média de aprovação é
            // igual a cinco.
            double p1 = 0, p2 = 0, notaMinimaAprovacao = 0, media = 0;
            try
            {
                Console.Write("Digite a nota da primeira avaliação: ");
                p1 = double.Parse(Console.ReadLine());
                notaMinimaAprovacao = (15 - p1) / 2;
                Console.WriteLine($"Para ser aprovado você precisa tirar no mínino nota: {notaMinimaAprovacao} ");
                Console.Write("Digite a nota da segunda avaliação: ");
                p2 = double.Parse(Console.ReadLine());
                media = (p1 + (2 * p2)) / 3; 
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadLine();
                return;
            }
            if (media >= 5)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
            Console.ReadKey();
        }
    }
}
