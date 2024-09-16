Console.WriteLine("Bem vindo ao conversor de moeda! Vamos converter para euro\n");

Console.WriteLine("Qual o valor que você quer converter ?");
float valorParaConverter = float.Parse(Console.ReadLine());

float converterMoeda(float valorParaConverter)
{
    float taxaDeConversao = float.Parse("0,16");
    return (valorParaConverter * taxaDeConversao);
}


Console.WriteLine(converterMoeda(valorParaConverter).ToString("f2"));