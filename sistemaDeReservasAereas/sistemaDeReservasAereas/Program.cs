using sistemaDeReservasAereas;
using System;

Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("|                          PIX AIRLINES                                 |");
Console.WriteLine("|                                                                       |");
Console.WriteLine("|                    1.CRIAR RESERVA                                    |");
Console.WriteLine("|                    2.EDITAR RESERVA                                   |");
Console.WriteLine("|                    3.CANCELAR RESERVA                                 |");
Console.WriteLine("|                    4.CONSULTAR RESERVA                                |");
Console.WriteLine("|                                                                       |");
Console.WriteLine("-------------------------------------------------------------------------");

Console.WriteLine("escolha uma opçao acima!");
int opcaoEscolhida = int.Parse(Console.ReadLine());



switch (opcaoEscolhida)
{
    case 1:
        Console.Clear();
        criarReserva();
        break;
    case 2:
        editarReserva();
        break;
    case 3:
        cancelarReserva();
        break;
    case 4:
        consultarReserva();
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}



void criarReserva()
{
    Console.WriteLine("*Vamos criar uma reserva:"); 
    Console.WriteLine("Seu nome para a reserva:*");
    string nome = Console.ReadLine();

    Console.WriteLine("Numero do voo:");
    int numeroDoVoo = int.Parse(Console.ReadLine());

    Console.WriteLine("Numero da reserva:");
    int numeroDeReserva = int.Parse(Console.ReadLine());

    Console.WriteLine("Numero de telefone de algum familiar:");
    int telefone = int.Parse(Console.ReadLine());

    //Reserva reservapix = new Reserva("joao","747","2578","1469654799");









}

void editarReserva()
{

}


void cancelarReserva()
{

}


void consultarReserva()
{

}








