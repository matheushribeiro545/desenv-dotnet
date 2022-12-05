using desenv_dotnet.Models;

// Menu interativo

string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear(); // Limpa o console
    Console.WriteLine("Digite a sua opçāo:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opçāo inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");