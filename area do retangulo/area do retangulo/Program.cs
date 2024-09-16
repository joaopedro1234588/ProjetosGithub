Console.WriteLine("digite a altura do terreno");
float altura =float.Parse( Console.ReadLine());

Console.WriteLine("digite a largura do tereno");
float largura =  float.Parse( Console.ReadLine());



float calculoInterno( float largura,float altura)
{
    return largura * altura;
   
}
float resultadoDaArea  = calculoInterno(largura,altura);

Console.WriteLine("o resultado é esse");
Console.WriteLine(resultadoDaArea);


    ;






























