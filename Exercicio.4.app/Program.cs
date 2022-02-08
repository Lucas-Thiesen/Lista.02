using System;

namespace Exercicio._4.app
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se
        //é par ou ímpar.
        public static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par");
            else
                Console.WriteLine("O número é ímpar");

            Console.ReadKey();
        }
    }
}
