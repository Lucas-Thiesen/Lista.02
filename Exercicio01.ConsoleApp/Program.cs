using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

          
        {
        double a, b, c, soma;
           
            
        Console.WriteLine("Algoritmo A+B");
            Console.WriteLine("Insira o valor de A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor de C");
            c = Convert.ToDouble(Console.ReadLine());

            soma = a + b;
           
            if (soma < c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }



            Console.ReadLine();



        }
    }
}
