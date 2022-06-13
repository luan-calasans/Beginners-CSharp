using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex06
{
    internal class C37461_ListaVetores_ex06
    {
        static void Main(string[] args)
        {
            /*
                Ler as duas notas bimestrais para um conjunto de 10 alunos. Armazenar as notas informadas 
                em dois vetores “Nota1” e “Nota2” do tipo real. Escreva um programa que calcule a média
                aritmética simples das notas informadas armazenando o resultado em um vetor “Result” de 
                mesmo tipo e tamanho. Ao mostrar os resultados exibir a situação de cada aluno. Se a
                média calculada for superior ou igual a 7 o aluno estará “aprovado”, caso contrário, 
                a situação do aluno será “reprovado”.
             */
            string[] student = new string[10];
            double[] grade1 = new double[10], grade2 = new double[10], result = new double[10];
            Console.WriteLine("================================");
            Console.WriteLine("  MÉDIA BIMESTRAL DE 10 ALUNOS  ");
            Console.WriteLine("================================");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite seu nome: ");
                student[i] = Console.ReadLine();

                Console.Write("Digite sua 1º nota: ");
                grade1[i] = double.Parse(Console.ReadLine());

                Console.Write("Digite sua 2º nota: ");
                grade2[i] = double.Parse(Console.ReadLine());

                result[i] = (nota1[i] + nota2[i]) / 2;
                if (result[i] >= 7)
                {
                    Console.Write($"Parabéns {student[i]}! Você foi ");
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("aprovado(a)"); 
                    Console.ForegroundColor = ConsoleColor.Gray; Console.Write($" com média {result[i]}\n");
                }
                else
                {
                    Console.Write($"Sinto muito {student[i]}! Você foi ");
                     Console.ForegroundColor = ConsoleColor.Red;Console.Write("reprovado(a)");
                    Console.ForegroundColor = ConsoleColor.Gray; Console.Write($" com média {result[i]}\n");
                }
                if (i != 9)
                {
                    Console.WriteLine("-------------------------------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
