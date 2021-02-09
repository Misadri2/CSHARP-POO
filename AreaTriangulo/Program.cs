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

            double p = (t.A + t.B + t.C) /2.0;
            double areat = Math.Sqrt(p*(p-t.A)*(p-t.B)*(p-t.C));

            double p2 = (t2.A + t2.B + t2.C) /2.0;
            double areat2 = Math.Sqrt(p*(p-t2.A)*(p-t2.B)*(p-t2.C));

            Console.WriteLine("Area do t " + areat);
            Console.WriteLine("Area do t2 " + areat2);

        }
    }
}
