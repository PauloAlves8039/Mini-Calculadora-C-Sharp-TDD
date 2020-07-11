using System;

namespace Calculadora.TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** MINI CALCULADORA **********");

            Console.Write("Digite o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            Calculadora c = new Calculadora(v1, v2);

            Console.WriteLine("\n********** RESULTADO **********");

            Console.WriteLine("A soma é: " + c.Somar(v1, v2) 
                              + "\nA subtração é: " + c.Subtrair(v1, v2) 
                              + "\nA multiplicação é: " + c.Multiplicar(v1, v2) 
                              + "\nA divisão é: " + c.Dividir(v1, v2));

            Console.ReadKey();
        }
    }
}
