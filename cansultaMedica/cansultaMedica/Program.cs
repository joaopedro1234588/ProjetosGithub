internal class Program
{
    private static void Main(string[] args)
    {
        List<string> medicos = new List<string>();
        menu();
        void menu()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("|                                                  |");
            Console.WriteLine("|              1- Consulta                         |");
            Console.WriteLine("|              2- Medico disponivel                |");
            Console.WriteLine("|              3- Adiar consulta                   |");
            Console.WriteLine("|              4- Visualizar consulta              |");
            Console.WriteLine("|              5- criar medico                     |");
            Console.WriteLine("|              6- Sair                             |");
            Console.WriteLine("|                                                  |");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("escolha uma opçao acima!");
            int opcaoEscolhida = int.Parse(Console.ReadLine());


            switch (opcaoEscolhida)
            {
                case 1:
                    Console.Clear();
                    Consulta();
                    break;
                case 2:

                    MedicoDisponivel();

                    break;
                case 3:
                    AdiarConsulta();
                    break;
                case 4:
                    Console.Clear();
                    VisualizarConsulta();
                    break;
                case 5:
                    Medicos();
                    break;
                
            }
        }








        void Consulta()
        {
            Console.Clear();
            Console.WriteLine("vamos marcar sua consulta\n");
            
            
                Console.WriteLine("digite a data da sua consulta");
                string dataDaConsulta = Console.ReadLine();


                if (medicos.Count > 0)
                {
                    Console.WriteLine("sua consulta vai ser com o " + medicos[0].ToString());
                }
                else
                {
                    Console.WriteLine("cadatre um medico para ser atendida");

                }
}
            
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            menu();

        

        void MedicoDisponivel()
        {
            Console.Clear();
            if (medicos.Count > 0)
            {
                Console.WriteLine("medicos disponivel");
                foreach (var medicos in medicos)
                {
                    Console.WriteLine(medicos);
                }
            }
            else
            {
                Console.WriteLine("Nenum medico disponivel");

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            menu();

        }
        void AdiarConsulta()
        {
            Console.Clear();
            Console.WriteLine("digite uma nova data pra sua consulta!");
            string novaDataDaConsulta = Console.ReadLine();

            Console.WriteLine("sua consulta foi adiada para " + novaDataDaConsulta);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            menu();

        }

        void VisualizarConsulta()
        {

            Console.Clear();

            Console.WriteLine("visualizando  consulta ...");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            menu();
        }


        void Medicos()
        {
            Console.Clear();
            Console.WriteLine("Cadastre um médico para a consulta:");

            string nomeMedico = Console.ReadLine();
            if (!string.IsNullOrEmpty(nomeMedico))
            {
                medicos.Add(nomeMedico);
                Console.WriteLine($"Médico {nomeMedico} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome do médico não pode ser vazio");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            menu();
        }
    }
}