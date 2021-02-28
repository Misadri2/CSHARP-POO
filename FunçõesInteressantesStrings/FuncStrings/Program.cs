using System;

namespace FuncStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //! Funções de Strings
            string original = " abc def ghi JLM nOP  ";
            string s1 = original.ToUpper();               // Deixa a string em letra maiúscula
            string s2 = original.ToLower();               // Deixa a string em minúscula
            string s3 = original.Trim();                  // Insere traços no início e fim da string
            int n1 = original.IndexOf("bc");              // Encontra primeira aparição na string do item indicado
            int n2 = original.LastIndexOf("bc");          // Encontra última aparição na string do item indicado
            string s4 = original.Substring(3);            // Recorta a string a partir da posição 3
            string s5 = original.Substring(3, 5);         // Recorta a string da posição 3 até 5.
            string s6 = original.Replace('a', 'x');       // Troca letra "a" por "x"
            string s7 = original.Replace("abc", "xy");    // Troca letra "abc" por "xy"
            bool b1 = String.IsNullOrEmpty(original);     // Informa se o campo está nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); // Informa se o campo está nulo ou tem espaços em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
          
          //! Date time
            Console.WriteLine("***********************************************************");          
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(date1);
            var date2 = DateTime.Now;
            Console.WriteLine(date2);
            
        }
    }
}
