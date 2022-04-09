using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_lista03_ex09
{
    class C37461_lista03_ex09
    {
        static void Main(string[] args)
        {
            // Uma escola com cursos em regime semestral, realiza duas avaliações
            // durante o semestre e calcula a média do aluno da seguinte maneira:
            // media = (P1 + (2 * P2)) / 3
            // Fazer um programa para entrar via teclado com os valores das notas (P1 e
            // P2) e calcular a média, exibir a situação final do aluno ("Aprovado" ou
            // "Reprovado"), sabendo que a média de aprovação é igual a 5.
            double p1 = 0, p2 = 0, media = 0;
            try 
            { 
                Console.Write("Digite a nota da primeira avaliação: ");
                p1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota da segunda avaliação: ");
                p2 = double.Parse(Console.ReadLine());
                media = (p1 + (2 * p2)) / 3;
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }
            if (media >= 5)
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
            Console.ReadKey();
        }
    }
}
