using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("BEM-VINDO AO SISTEMA DE NOTAS");
            Console.WriteLine("-----------------------------");

            float nota1 = 0F;
            float nota2 = 0F;

            Console.Write("Informe a nota da primeira prova: ");
            float.TryParse(Console.ReadLine(), out nota1);

            Console.Write("Informe a nota da segunda prova: ");
            float.TryParse(Console.ReadLine(), out nota2);

            float media = (nota1 + nota2) / 2;

            Console.WriteLine($"As notas registradas foram {nota1:F1} e {nota2:F1}");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("CALCULANDO ...");
            Thread.Sleep(3000);
            Console.SetCursorPosition(0, 6);

            if(media >= 0F && media < 3.0F)
            {
                Console.WriteLine($"Sinto muito, você ficou com média {media} e vai precisar refazer o curso.");
            }
            else if(media >= 3F && media < 7F)
            {
                Console.WriteLine($"Tome cuidado, você ficou com média {media} e está de recuperação.");
            }
            else
            {
                Console.WriteLine($"Parabéns !! você ficou com média {media} e passou para o próximo módulo do curso.");
            }

            Console.ReadKey();

        }
    }
}
