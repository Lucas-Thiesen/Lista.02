using System;

namespace Exercicio._5.app
{
    internal class Program
    {
        // Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
        //iguais deverá se somar os dois, caso contrário multiplique A por B.
        // Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
        public static void Main(string[] args)
        {
            int valorA, valorB, valorC = 0;

            Console.Write("Digite o valor A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            if (valorA == valorB)
                valorC = valorA + valorB;
            else
                valorC = valorA * valorB;

            Console.WriteLine("\nO valor C é: " + valorC);

            Console.ReadKey();
        }
    }
}
