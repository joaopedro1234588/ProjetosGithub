
const int numeroSecreto = 7;

int palpite = 0;


Console.WriteLine("Tente adivinhar o número secreto!");

while (palpite != numeroSecreto)
{
 
    Console.Write("Digite seu palpite: ");
    
    string input = Console.ReadLine();

    
    if (int.TryParse(input, out palpite))
    {
        if (palpite != numeroSecreto)
        {
           
            Console.WriteLine("Palpite incorreto. Tente novamente.");
        }
    }
    else
    {
        
        Console.WriteLine("Por favor, insira um número válido.");
    }
}


Console.WriteLine("Parabéns! Você acertou o número secreto!");

