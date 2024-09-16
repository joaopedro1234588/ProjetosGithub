 Console.WriteLine("digite um numero para ver se ele e positivo ou negativo:");
int numero = int.Parse(Console.ReadLine());


    if (numero > 0)
        Console.WriteLine("O número é positivo.");
    else if (numero < 0)
        Console.WriteLine("O número é negativo.");
    else
        Console.WriteLine("O número é zero.");
