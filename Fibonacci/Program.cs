using System.Transactions;

namespace Fibonacci
{
    //Escreva um programa em C# que exiba a sequência de Fibonacci. A sequência começa com 0 e 1, e cada número
    //subsequente é a soma dos dois números anteriores. O programa deve solicitar ao usuário um número inteiro
    //N e exibir os N primeiros números da sequência de Fibonacci.
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada;
            Console.WriteLine("Digite o numero que deseja exibir a sequencia: ");
            while (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.WriteLine("Valor invalido digite um numero inteiro positivo: ");
            }
            List<int> sequenciaDeFibonacci = new List<int>();
            if (entrada >= 0)
            {
                sequenciaDeFibonacci.Add(0);
                if (entrada >= 1)
                {
                    sequenciaDeFibonacci.Add(1);
                    int penultimoNumero = 0;
                    int numeroAtual = 1;

                    while (numeroAtual + penultimoNumero <= entrada)
                    {
                        int fibonacci = numeroAtual + penultimoNumero;
                        penultimoNumero = numeroAtual;
                        numeroAtual = fibonacci;
                        sequenciaDeFibonacci.Add(fibonacci);
                    }
                }
            }
            foreach (int fib in sequenciaDeFibonacci)
            {
                Console.WriteLine(fib);
            }
        }
    }
}