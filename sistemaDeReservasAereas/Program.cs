using sistemaDeReservasAereas;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Trocando as variaveis por uma lista
/*string nome = "";
int numeroDoVoo = 0;
int numeroDaReserva = 0;
int telefone = 0;*/

// Lista de reservas
List<Reserva> ListaDeReservas = new List<Reserva>();

#if DEBUG
Reserva reservaTeste = new Reserva("cleber", 841, 963, 8);
Reserva reservaTeste2 = new Reserva("claldineia", 289, 936, 96);
ListaDeReservas.Add(reservaTeste);
ListaDeReservas.Add(reservaTeste2);
#endif

menu();

void menu()
{

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
            Console.Clear();
            consultarReserva();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void criarReserva()
{
    Console.WriteLine("*Vamos criar uma reserva:");
    Console.WriteLine("Seu nome para a reserva:*");
    string nome = Console.ReadLine();

    int numero;
    string entrada;

    Console.WriteLine("Digite o numero do voo:");
    int numeroDoVoo = 0;
    while (true)
    {
        entrada = Console.ReadLine();

        // Tenta converter a entrada para inteiro
        if (int.TryParse(entrada, out numero))
        {
            numeroDoVoo = numero;
            break;
        }
        else
        {
            // Informa ao usuário que a entrada é inválida
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
        }

    }


    int numero2;
    string entrada2;

    Console.WriteLine("Digite o Numero da reserva:");
    int numeroDaReserva = 0;
    


    while (true)
    {
        entrada2 = Console.ReadLine();
        
        
        // Tenta converter a entrada para inteiro
        if (int.TryParse(entrada2, out numero2))
        {
            numeroDaReserva = numero2;
            break;
        }
        else
        {
            // Informa ao usuário que a entrada é inválida
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
        }
    }







    int numero3;
    string entrada3;

    Console.WriteLine("Digite o Numero de telefone:");

    int telefone = 0;

    while (true)
    {
        entrada2 = Console.ReadLine();

        // Tenta converter a entrada para inteiro
        if (int.TryParse(entrada2, out numero3))
        {
            telefone = numero3;
            break;
        }
        else
        {
            // Informa ao usuário que a entrada é inválida
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
        }
    }

    // Aqui você carrega a reserva
    Reserva reserva = new Reserva(nome, numeroDoVoo, numeroDaReserva, telefone);

    // Aqui você salva a reserva na lista
    ListaDeReservas.Add(reserva);


    Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
    Console.ReadLine();
    Console.Clear();
    menu();

}

void editarReserva()
{

    Console.Clear();
    Console.WriteLine("Qual reserva vc deseja editar?");
    int numeroDaReserva = int.Parse(Console.ReadLine());

    bool entrouNoIf = false;

    foreach (Reserva reserva in ListaDeReservas)
    {
        if (reserva.NumeroDeReservas == numeroDaReserva)
        {
            entrouNoIf = true;
            Console.WriteLine("Digite um novo nome:");
            reserva.Nome = Console.ReadLine();

            int numeroConvertido;
            string entrada1;

            Console.WriteLine("Digite o número do voo:");

            while (true)
            {
                entrada1 = Console.ReadLine();

                // Tenta converter a entrada para inteiro
                if (int.TryParse(entrada1, out numeroConvertido))
                {
                    reserva.NumeroDoVoo = numeroConvertido;
                    break;
                }
                else
                {
                    // Informa ao usuário que a entrada é inválida
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
                }
            }

            int numero2;
            string entrada2;

            Console.WriteLine("Digite um novo telefone:");

            while (true)
            {
                entrada2 = Console.ReadLine();

                // Tenta converter a entrada para inteiro
                if (int.TryParse(entrada2, out numero2))
                {
                    // Se a conversão for bem-sucedida, sai do laço
                    break;
                }
                else
                {
                    // Informa ao usuário que a entrada é inválida
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
                }
            }

        }

    }


    if (entrouNoIf == false)
    {
        Console.WriteLine("reserva nao encontrada");
    }
    else
    {
        Console.WriteLine("reserva editada com sucesso!");
    }



    Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
    Console.ReadLine();
    Console.Clear();
    menu();
}





void cancelarReserva()
{
    Console.Clear();
    Console.WriteLine("Qual reserva vc deseja cancelar?");
    int numeroDaReserva = int.Parse(Console.ReadLine());
    bool entrouNoIf = false;
    foreach (Reserva reserva in ListaDeReservas)
    {
        if (reserva.NumeroDeReservas == numeroDaReserva)
        {
            entrouNoIf = true;
            ListaDeReservas.Remove(reserva);
            Console.WriteLine("Reserva cancelada com sucesso !");
            break;
        }
    }

    if (entrouNoIf == false)
    {
        Console.WriteLine("reserva nao encontrada");
    }
    else
    {
        Console.WriteLine("reserva editada com sucesso!");
    }






















    Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
    Console.ReadLine();
    Console.Clear();
    menu();
}


void consultarReserva()
{
    // Perguntar qual o numero da reserva o usuario quer ver
    Console.WriteLine("qual o numero da reserva vc quer ver?");
    int numeroReserva = int.Parse(Console.ReadLine());
    bool encontrou = false;

    foreach (Reserva reserva in ListaDeReservas)
    {
        if (reserva.NumeroDeReservas == numeroReserva)
        {

            Console.WriteLine("numeroDeReserva: " + reserva.NumeroDeReservas);
            Console.WriteLine($"telefone: {reserva.Telefone}");
            Console.WriteLine($"numeroDoVoo: {reserva.NumeroDoVoo}");
            Console.WriteLine($"nome: {reserva.Nome}");
            encontrou = true;
        }

    }
    if (!encontrou)
    {
        Console.WriteLine("reserva não encontrada");
    }


    Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
    Console.ReadLine();
    Console.Clear();
    menu();

}

