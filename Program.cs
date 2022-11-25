using desenv_dotnet.Models;

////Switch case
Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Nāo é uma vogal");
// }

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
        
    default:
        Console.WriteLine("Nāo é uma vogal");
        break;
}