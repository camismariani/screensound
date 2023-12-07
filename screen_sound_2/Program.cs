// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "Mamonas", "Beatles", "RHCP" };



void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("**************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("**************************");

}

void ExibiOpcoesDoMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirListaDeBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Encerrando o programa");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine(" Registro de bandas");
    Console.WriteLine("********************\n");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.Write($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibiOpcoesDoMenu();
}


void ExibirListaDeBandas()
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine(" Exibindo as bandas registradas");
    Console.WriteLine("********************************\n");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.Write($"Banda: {listaDasBandas[i]}\n");
    //}

    foreach (string banda in listaDasBandas)
    {
        Console.Write($"Banda: {banda}\n");
    }



    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibiOpcoesDoMenu();


}

ExibiOpcoesDoMenu();