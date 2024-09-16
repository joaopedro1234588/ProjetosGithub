Console.WriteLine("Bem vindo, vc está pronto(a) para descubrir o seu peso em outros planetas?\n");

Console.WriteLine("Digite a  sua massa: ");
float massa = float.Parse(Console.ReadLine());


Console.WriteLine("Digite a primeira letra do planeta que você está (Terra-> T / Marte - M / Vênus - V / Júpiter - J / Saturno - S )");
char nomeDoPlaneta  = char.Parse(Console.ReadLine());



float calcularPesoEmPlanetas(char nomeDoPlaneta,float massa)
{
    float gravidade = 0;

    switch (nomeDoPlaneta)
    {
        case 'T' or 't':
            gravidade = 9.81f;
            break;
        case 'M'or 'm':
            gravidade = 3.71f;
            break;
        case 'V' or 'v':
            gravidade = 8.87f;
            break;
        case 'J' or 'j':
            gravidade = 24.79f;
            break;
        case 'S' or 's':
            gravidade = 10.44f;
            break;
    }

        /*
        if (nomeDoPlaneta == 'T')
        {
            gravidade = 9.81f;
        }
        else if (nomeDoPlaneta == 'V')
        {
            gravidade = 8.87f;
        }
        else if (nomeDoPlaneta == 'M')
        {
            gravidade = 3.71f;
        }
        else if (nomeDoPlaneta == 'J')
        {
            gravidade = 24.79f;
        }
        else if (nomeDoPlaneta == 'S') 
        {
            gravidade = 10.44f;
        }
        */
        return massa * gravidade;
}



Console.WriteLine("O seu peso no planeta que vc escolheu é: ");
Console.WriteLine(calcularPesoEmPlanetas(nomeDoPlaneta,massa));































