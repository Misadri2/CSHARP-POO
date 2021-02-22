using System;

namespace MediaVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe quantos produtos você quer cadastrar:");

            int n = int.Parse(Console.ReadLine()); // Para informar número de produtos que serão inseridos

            Product[] vect = new Product[n];    //Instanciando a classe e o vetor

            for(int i = 0; i < n; i++){             // Utilizando "for" para repetir a operação n vezes
                Console.WriteLine("Informe nome e preço do produto:");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product{ Name=name, Price=price};  // Instanciando nome e preço da classe no vetor
            }

            double sum = 0;

            for(int i = 0; i < n; i++){
                sum = sum + vect[i].Price;  // Utilizando "for" para somar o número de vezes que possui o vetor e indicando o Price
            }

            double avg = sum / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2"));
        }
    }
}
