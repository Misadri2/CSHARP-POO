using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Triangulo t2 = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo t : ");
            t.A = double.Parse(Console.ReadLine());
            t.B = double.Parse(Console.ReadLine());
            t.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo t2 : ");
            t2.A = double.Parse(Console.ReadLine());
            t2.B = double.Parse(Console.ReadLine());
            t2.C = double.Parse(Console.ReadLine());

            double areat = t.Area();

            double areat2 = t2.Area();

            Console.WriteLine("Area do t " + areat);
            Console.WriteLine("Area do t2 " + areat2);

        }
    }
}
