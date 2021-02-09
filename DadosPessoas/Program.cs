using System;

namespace DadosPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            
        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome");
        p1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());

        }
    }
}
