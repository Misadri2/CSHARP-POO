using System;

namespace OrientaçãoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();

            Console.Write("Nome 1: ");
            P1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            P1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome 2: ");
            P2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            P2.Idade = int.Parse(Console.ReadLine());

            if( P1.Idade > P2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é :" + P1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + P2.Nome);
            }

        }
    }
}
