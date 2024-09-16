Random random = new Random();
int numeroAleatorio = random.Next(1, 101);

int palpite = 0;
int tentativas = 0;

Console.WriteLine("Bem-vindo ao jogo da adivinhação!\n");
Console.WriteLine("Eu escolhi um número entre 1 e 100. Tente adivinhar!\n");


while (palpite != numeroAleatorio)
{
    Console.Write("Digite seu palpite: ");
    palpite = Convert.ToInt32(Console.ReadLine());
    tentativas++;

   
    if (palpite < numeroAleatorio)
    {
        Console.WriteLine("O número é maior!");
    }
    else if (palpite > numeroAleatorio)
    {
        Console.WriteLine("O número é menor!");
    }
    else
    {
        Console.WriteLine($"Parabéns! Você adivinhou o número {numeroAleatorio} em {tentativas} tentativas.");
    }
}











