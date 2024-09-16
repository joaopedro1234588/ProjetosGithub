using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um CPF (no formato ###.###.###-##):");
        string cpf = Console.ReadLine();

       
        if (!Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
        {
            Console.WriteLine("CPF no formato inválido.");
            return;
        }

        
        string cpfNumeros = cpf.Replace(".", "").Replace("-", "");

        if (ValidarCpf(cpfNumeros))
        {
            Console.WriteLine("CPF válido!");
        }
        else
        {
            Console.WriteLine("CPF inválido.");
        }
    }

    static bool ValidarCpf(string cpf)
    {
        
        if (new string(cpf[0], cpf.Length) == cpf)
        {
            return false;
        }

        
        int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string cpfSemDigito = cpf.Substring(0, 9);
        string digitosVerificadores = cpf.Substring(9, 2);

     
        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpfSemDigito[i].ToString()) * multiplicadores1[i];
        }

        int primeiroDigito = soma % 11;
        primeiroDigito = primeiroDigito < 2 ? 0 : 11 - primeiroDigito;

    
        soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpfSemDigito[i].ToString()) * multiplicadores2[i];
        }

        int segundoDigito = soma % 11;
        segundoDigito = segundoDigito < 2 ? 0 : 11 - segundoDigito;

      
        return digitosVerificadores == $"{primeiroDigito}{segundoDigito}";
    }
}
