using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            float meses, dias, horas, minutos;
            Console.Write("Digite sua idade : ");
            idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            Console.WriteLine("Você viveu " + meses +" meses.");

            dias = idade * 365;
            Console.WriteLine("Você viveu " + dias +" dias.");

            horas = idade * 8766;
            Console.WriteLine("Você viveu " + horas +" horas.");

            minutos = idade * 525600;
            Console.WriteLine("Você viveu " + minutos +" minutos.");
        }
    }
}
