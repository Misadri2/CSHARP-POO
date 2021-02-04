using System;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Digite um número: ");
            numero = Math.Sqrt(double.Parse(Console.ReadLine()));

            while (numero >= 0);
            {               
                Console.WriteLine(numero.ToString("F3"));
                Console.WriteLine("Digite outro número: ");
                numero = Math.Sqrt(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Número negativo");
           

        }
    }
}
