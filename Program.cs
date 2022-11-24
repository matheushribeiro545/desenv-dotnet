using desenv_dotnet.Models;

//// Atribuiçōes

// int a = 1;
// int b = 2;

// int c = a + b;

// // c = c + 5;
// c += 5; //Ao colocar um operador antes do =, é realizado a operaçāo sem atribuir o número

// Console.WriteLine(c);


///// Cast - Casting

//int a = Convert.ToInt32("5"); //Retorna nulos como zero (mais recomendado)
//int a = int.Parse("5"); //Nāo trata valores nulos


// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

//// Gerar exceçāo sem quebrar o programa

string a = "5a";

int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversāo realizada com sucesso");