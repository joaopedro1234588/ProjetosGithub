/*List<string> nomes = new List<string> { "joao", "jean", "titi", "gabriel" };


foreach (string nome in nomes)
{
    Console.WriteLine($"Olá, {nome}!");
}
*/


Carro cc = new Carro();
cc.cor = "cinza";
cc.marca = "honda";
cc.acelerar();
cc.modelo = "honda-fit";
cc.valorFipe = 76738;
Carro cg = new Carro();
cg.cor = "laranja";
cg.marca = "renault";
cg.modelo = "kwid";
cg.valorFipe += 44274;

Console.WriteLine("esse e o carro do cesinha");
Console.WriteLine(cc.marca +"  "+ cc.cor + "  "+cc.modelo + "  "+cc.valorFipe);
Console.WriteLine("agora o carro do gabriel");
Console.WriteLine(cg.marca + "  " + cg.cor + "  " + cg.modelo + "  " + cg.valorFipe);

public class Carro
{
    public string cor { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }

    public float valorFipe { get; set; }
    public void acelerar()
    {

    }

    public void freiar()
    {

    }
}






















































































