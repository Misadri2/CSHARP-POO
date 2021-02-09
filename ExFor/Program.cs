using System;

namespace ExFor
{
    class Program
    {
        static void Main(string[] args)
        {   
            
           int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double x = double.Parse(line[0]);
                double y = double.Parse(line[1]);
                if (y != 0)
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
    