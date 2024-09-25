// screen sound
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
List<string> listaDasBandas = new List<string>();
Dictionary<string, List<int>> bandasResdagitradas = new Dictionary<string, List<int>>();
bandasResdagitradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasResdagitradas.Add("The Beatles", new List<int>());
void exibirMensagemDeBoasVindas()
{
    List<string> listaDasBandas = new List<string> { };

    //fundo    Console.BackgroundColor = ConsoleColor.Black;
    //escrita
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("\r\n██████╗░██╗██╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░\r\n██╔══██╗██║╚██╗██╔╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗\r\n██████╔╝██║░╚███╔╝░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║\r\n██╔═══╝░██║░██╔██╗░  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║\r\n██║░░░░░██║██╔╝╚██╗  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝\r\n╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    Console.WriteLine(" \r\n██████╗░░█████╗░░█████╗░░██████╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░██████╗\r\n██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗██╔════╝\r\n██████╦╝██║░░██║███████║╚█████╗░  ╚██╗░██╔╝██║██╔██╗██║██║░░██║███████║╚█████╗░\r\n██╔══██╗██║░░██║██╔══██║░╚═══██╗  ░╚████╔╝░██║██║╚████║██║░░██║██╔══██║░╚═══██╗\r\n██████╦╝╚█████╔╝██║░░██║██████╔╝  ░░╚██╔╝░░██║██║░╚███║██████╔╝██║░░██║██████╔╝\r\n╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░ ");
    Console.WriteLine("---------------------------------------------------------------------------------------------------");
    Console.ResetColor();


}

void ExibirOpcoesDoMenu()
{


    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Digite 1 para resgistra uma banda.");
    Console.WriteLine("Digite 2 para mostra todas as bandas.");
    Console.WriteLine("Digite 3 para  avaliar uma banda. ");
    Console.WriteLine("Digite 4 para exibir a media de uma banda.");


    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            ResgistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


void ResgistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Resgistro De Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasResdagitradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda}  foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    exibirMensagemDeBoasVindas();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas resgistradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasResdagitradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirMensagemDeBoasVindas();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int QuantidadeDeletras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(QuantidadeDeletras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{

    Console.Clear();
    ExibirTituloDaOpcao("Avaviar banda");
    Console.Write("Digite o nome da banda que deseja Valiar: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasResdagitradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"qual a nota que a banda {nomeDaBanda} merece : ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasResdagitradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota}foi resgistrada com sucesso com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        exibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\n A banda{nomeDaBanda}não foi encontrada!");
        Console.WriteLine("digite uma tecla para voltar menu primcipal");
        Console.ReadKey();
        Console.Clear();
        exibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();

    }

}
void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Media da banda");
    Console.Write("Digite o nome da banda que deseja exibir a media : ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasResdagitradas.ContainsKey(nomeDaBanda))
    {

        List<int> notasDaBanda = bandasResdagitradas[nomeDaBanda];
        Console.WriteLine($"\n A media da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("digite uma tecla para voltarao menu primcipal");
        Console.ReadKey();
        Console.Clear();
        exibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();
    }

}




//execuçao
exibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
AvaliarUmaBanda();