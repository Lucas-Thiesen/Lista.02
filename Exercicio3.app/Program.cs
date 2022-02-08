using System;

namespace Exercicio3.app
{
    internal class Program
    {
        static void Main(string[] args)
            // • O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde
            // para dar uma indicação sobre a condição de peso de uma pessoa adulta.
            //• A fórmula é IMC = peso / (altura) ²
            //• Elabore um algoritmo que leia o peso e a altura de um adulto
            //e mostre sua condição de acordo com a tabela abaixo.
        {
            double peso, altura, imc;
            Console.WriteLine("IMC Ativida ACADEMIA");
            Console.WriteLine("Informe o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a sua altura");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("Peso normal");
            else if (imc > 25 && imc < 30)
                Console.WriteLine("Acima do peso");
            else if (imc > 30)
                Console.WriteLine("Obeso");

            Console.ReadKey();

        }
    }
}
