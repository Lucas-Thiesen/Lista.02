using System;

namespace Exercicio._02.app
{
    internal class Program
    {
        static void Main(string[] args)
            // Exercício 2:• Escreva um algoritmo que leia três valores inteiros
            // e diferentes e mostre-os em ordem decrescente.
        
        {
            int valor1, valor2, valor3;
            
            Console.WriteLine("Insira três valores!");
            Console.WriteLine("Valor 1");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 2");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 3");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor2 > valor3)
                Console.WriteLine("{0} {1} {2}", valor1, valor2, valor3);

            else if (valor1 > valor2 && valor1 > valor3 && valor3 > valor2)
                Console.WriteLine("{0} {1} {2}", valor1, valor3, valor2);

            else if (valor2 > valor1 && valor1 > valor3)
                Console.WriteLine("{0} {1} {2}", valor2, valor1, valor3);

            else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
                Console.WriteLine("{0} {1} {2}", valor2, valor3, valor1);

            else if (valor3 > valor2 && valor2 > valor1)
                Console.WriteLine("{0} {1} {2}", valor3, valor2, valor1);

            else if (valor3 > valor2 && valor1 > valor2)
                Console.WriteLine("{0} {1} {2}", valor3, valor1, valor2);

            Console.ReadKey();





        }
    }
}
