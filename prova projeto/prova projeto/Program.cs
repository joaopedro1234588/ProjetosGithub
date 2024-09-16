using System.ComponentModel.Design;

Console.WriteLine("bem vindo ");

 Console.WriteLine("digite sua idade");
int idade =int.Parse( Console.ReadLine());

void classificarIdade(int idade)
{
    if (idade <= 12)
        Console.WriteLine($"com {idade} anos vc e criança");
    else if (idade <= 17) 
        Console.WriteLine($"com {idade} anos   vc é adolescente");
    else if(idade >= 18) 
        Console.WriteLine($"com {idade} anos vc e adulto");
}

classificarIdade(idade);