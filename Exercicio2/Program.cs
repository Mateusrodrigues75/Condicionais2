using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, anoAtual, idade;
            double semanas;
            Console.Write(" Digite o ano do seu nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano da data atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            idade = anoAtual-anoNascimento;
            Console.WriteLine("Sua idade é " + idade + " anos.");

            semanas = idade * 52.1429;
            Console.WriteLine("Sua idade em semanas é " + semanas + " semanas.");




        }
    }
}
