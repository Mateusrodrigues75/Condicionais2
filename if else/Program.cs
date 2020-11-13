using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua Idade?");
            int idade = int.Parse(Console.ReadLine());
            if(idade>=18){
                Console.WriteLine("Você gostaria de participar do time de CS GO? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a SARA");
                }else{
                    Console.WriteLine("Blz, passar bem.");
                }
            }else{
                Console.WriteLine("Você gostaria de Participar do time de lol? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a  secretaria - Falar com o Jucelino");
                }else{
                    Console.WriteLine("Muito Obrigado");
                }
            }
        }
    }
}
