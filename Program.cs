
using System.Diagnostics;
using System.Linq.Expressions;

namespace Exer1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int faltas;

            Console.WriteLine("Introduza o número de faltas do aluno: ");
            faltas = Convert.ToInt32(Console.ReadLine());
            
            float nota1, nota2, nota3, media;

            if (faltas < 25) {
                Console.WriteLine("Insere as 3 notas do aluno: \n");
                nota1 = Convert.ToInt32(Console.ReadLine());
                nota2 = Convert.ToInt32(Console.ReadLine());
                nota3 = Convert.ToInt32(Console.ReadLine());

                media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("A média é de: {0}", media);
                Console.ReadLine();

               if (media <8)
                {
                    Console.WriteLine("Reprovado");
                    Console.ReadLine();
                } else if (media ==8 || media <10)
                {
                    Console.WriteLine("Recuperado");
                    Console.ReadLine();
                } else
                {
                    Console.WriteLine("Aprovado");
                    Console.ReadLine();
                }
                        



            } else{
                Console.WriteLine("Reprovado");
                Console.ReadLine();
            };

            

        }
    }
}

