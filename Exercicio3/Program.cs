using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário em R$: ");
            double salario = double.Parse(Console.ReadLine());

            if(salario<500.00){
                double novoSalario = (0.3*salario) + salario;
                Console.WriteLine(novoSalario);
                
            }else{
                Console.WriteLine("Você não tem direito ao aumento.");
            }
        }
    }
}
