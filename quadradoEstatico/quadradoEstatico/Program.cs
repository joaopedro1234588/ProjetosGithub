

/*Console.WriteLine("insira o tamanho do quadrado:");
int tamanho = int.Parse(Console.ReadLine());*/

using System.Runtime.CompilerServices;
using System.Xml;

int tamanho = 4;


for (int i = 1; i <= tamanho; i++)
{
    Console.WriteLine();

    if (i == 1 || i == 4)
    {
        // executar o for que exibe ****
        for (int j = 1; j <= tamanho; j++)
        {
            //Console.Write("* ");
            Console.Write("* ");

        }
        //Console.WriteLine("* * * *");
    }
    else
    {
        
        // executar o for que exibe *  *
        for (int j = 1; j <= tamanho; j++)
        {
            //Console.Write("* ");
            
            if(j == 1 || j == 4)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
   
    }
}













