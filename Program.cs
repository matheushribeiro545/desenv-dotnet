using desenv_dotnet.Models;

// Estrutura de repetiçāo

// int numero = 5;

//for (declarar variável; até quando; enquanto o contador for considerado)
// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numero = 10;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++; // Para nāo cair em loop infinito

//     // break; equivalente ao return do SQL server
// }

int soma = 0, numero = 0;

do 
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");