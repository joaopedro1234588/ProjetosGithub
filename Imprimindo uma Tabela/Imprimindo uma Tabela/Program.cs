using System;

class Program
{
    static void Main()
    {
        // Array com números inteiros
        int[] numeros = { 2, 4, 6, 8, 10 };

        // Variável para armazenar a soma
        int soma = 0;

        // Somando todos os elementos do array
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        // Exibindo a soma
        Console.WriteLine($"A soma dos elementos do array é: {soma}");
    }
}
