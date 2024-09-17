string senha = "1234@progamador";

Console.WriteLine("digite a senha correta");
string senha2 = Console.ReadLine();

while (senha2 != senha)
{
    Console.WriteLine("senha invalida");

    Console.WriteLine("digite novamente a senha ");
    senha2 = Console.ReadLine();
}

Console.WriteLine("senha correta");
