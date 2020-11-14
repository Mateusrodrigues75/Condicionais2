using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Qual sua Idade? ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7){
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Sua categoria de Nadador é Infantil A.");
            }
            if(idade >= 8 && idade <= 10){
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Sua categoria de Nadador é Infantil B.");
            }
            if(idade >= 11 && idade <= 13){
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Sua categoria de Nadador é Juvenil A.");
            }
            if(idade >= 14 && idade <= 17){
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Sua categoria de Nadador é Juvenil B.");
            }
            if(idade >=18){
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Sua categoria de Nadador é Sênior.");
            }
        }
    }
}
