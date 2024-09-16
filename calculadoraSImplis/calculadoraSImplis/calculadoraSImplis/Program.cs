Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Escolha a operação (+, -, *, /): ");
char operacao = Convert.ToChar(Console.ReadLine());

double resultado;

if (operacao == '+')
{
    resultado = numero1 + numero2;
    Console.WriteLine($"O resultado da adição é: {resultado}");
}
else if (operacao == '-')
{
    resultado = numero1 - numero2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
}
else if (operacao == '*')
{
    resultado = numero1 * numero2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
}
else if (operacao == '/')
{
    if (numero2 != 0)
    {
        resultado = numero1 / numero2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }
    else
    {
        Console.WriteLine("Erro: Não é possível dividir por zero.");
    }
}
else
{
    Console.WriteLine("Operação inválida!");
}


