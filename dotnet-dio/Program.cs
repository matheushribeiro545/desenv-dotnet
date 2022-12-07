using desenv_dotnet.Common.Models;

// Arrays 
int[] array = new int[5];

array[0] = 3; // Arrays começam pelo indice zero
array[1] = 10;
array[2] = 75;
array[3] = 9;
array[4] = 43;

// Redimensāo do array, mas de forma manual
int[] arrayCopia = new int[array.Length * 2];
Array.Copy(array, arrayCopia, array.Length);

// Redimensionar o tamanho do Array
//Array.Resize(ref array, array.Length * 2);

// Percorrendo array com FOR
for(int contador = 0; contador < array.Length; contador++)
{
    Console.WriteLine($"Posiçāo Número {contador} - {array[contador]}");
}

// Percorrendo array com FOREACH (Nāo exibe posiçāo)
// int contadorForeach = 0; // Para apresentaçāo da posiçāo no FOREACH
// foreach(int valor in array)
// {
//     Console.WriteLine($"Posiçāo N {contadorForeach} - {valor}");
//     contadorForeach++;
// }