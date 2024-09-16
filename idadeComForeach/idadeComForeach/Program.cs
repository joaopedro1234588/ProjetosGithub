string[] idade = new string[6];

for (int i = 0; i < 6; i++)
{
    if (i == 0)
    {
        Console.WriteLine("digite uma idade:");
    }
    else
    {
        Console.WriteLine("digite outra idade:");
    }

    idade[i] = Console.ReadLine();
}

foreach (string idades in idade)
{
    Console.WriteLine($"as idades sao essa {idades }");
}