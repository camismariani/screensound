// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string mensagemDeBoasVindas = "Boas vindas ao screen sound";



void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("**************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("**************************");

}

void ExibiOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    Console.ReadLine();
}


ExibirMensagemDeBoasVindas();
ExibiOpcoesDoMenu();