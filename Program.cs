using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {double n1,n2,n3,media;
            Console.WriteLine("Digite a primeira nota");
                n1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunnda nota");
                n2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
                n3=Convert.ToDouble(Console.ReadLine());

            //Calcular a media do aluno
            media = (n1 + n2 + n3) / 3;

            //Determinar se o aluno está aprovado sim ou não
            if (media >= 70)
            {
                Console.WriteLine("Aluno Aprovado com nota " + media);
            }
            if (media < 70)
                Console.WriteLine("Aluno Reprovado");
            Console.WriteLine("O programa terminou");
            Console.ReadKey();
        }
    }
}
