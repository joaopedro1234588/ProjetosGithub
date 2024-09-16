int[] primos = new int[10];
int contador = 0;
int numero = 2;

while (contador < 10)
{
    if (EhPrimo(numero))
    {
        primos[contador] = numero;
        contador++;
    }
    numero++;
}


Console.WriteLine("Os primeiros 10 números primos são:");
foreach (int primo in primos)
{
    Console.WriteLine(primo);
}


static bool EhPrimo(int num)
{
    if (num < 2) 
        return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}

