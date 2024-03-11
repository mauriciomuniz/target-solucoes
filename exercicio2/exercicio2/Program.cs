using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (VerificarSePertenceASequenciaFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

    }

    static bool VerificarSePertenceASequenciaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;
        int soma = 0;

        while (soma < numero)
        {
            soma = a + b;
            a = b;
            b = soma;
        }

        return soma == numero;
    }

}
