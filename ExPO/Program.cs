using System;

namespace ExercíciosWhile
{
    class Program
    {
        static void Main(string[] args){
        
            int x, y;

            Console.WriteLine("Digite o valor de x e y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro Quadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quarto Quadrante");
            }
            else
            {
                Console.WriteLine(" ");
            }

        }
    }
}
