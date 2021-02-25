using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de linhas e colunas: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] matriz = new int[m, n];                              //Instanciando a matriz

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Informe um valor X para ser encontrado na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {               //linha ( m  - i)
                for (int j = 0; j < n; j++)
                {            // coluna ( n - j )
                    if (matriz[i, j] == x) {          // Se houver na matriz nº igual x
                        Console.WriteLine("Position " + i + "," + j + ":");  // vai informar a posição
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        } if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        } if (j < n - 1) {                        
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        } if (i < m - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}