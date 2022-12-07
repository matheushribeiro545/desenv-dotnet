using desenv_dotnet.Common.Models;

// Lista - Nāo precisa citar capacitade máxima

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MG");
listaString.Add("PR");

// Percorrendo lista pelo FOR
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posiçāo N {contador} - {listaString[contador]}");
}

// Percorrendo lista pelo FOREACH
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posiçāo N {contadorForeach} - {item}");
    contadorForeach++;
}