using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de n para calcular o n-ésimo número da sequência de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = Fibonacci(n);
        Console.WriteLine($"O {n}-ésimo número da sequência de Fibonacci é: {resultado}");
    }

    static int Fibonacci(int n)
    {
        // Caso base
        if (n == 0) return 0;
        if (n == 1) return 1;

        // Chamada recursiva
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
