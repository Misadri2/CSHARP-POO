using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno  = new Aluno(); // Está aparecendo warning, mas roda normalmente e entrega resultado esperado.

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota Final: " + aluno.NotaFinal());

            if(aluno.NotaFinal() >= 60){
                Console.WriteLine("Aprovado");
            }else{
                Console.WriteLine("Reprovado");
            }

        }
    }
}
