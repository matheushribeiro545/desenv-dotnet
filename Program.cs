using desenv_dotnet.Models;

////Tipos de dados

DateTime dataAtual = DateTime.Now.AddDays(-5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// string apresentacao = "Olá, tudo bem?";

// int quantidade = 2;

// double altura = 1.75;

// decimal preco = 2.75M;

// bool condicao = false;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00")); //ToString para trazer mais casas após a virgula, apenas no double
// Console.WriteLine("Valor da variável preco: " + preco); //Mais recomendado para valores e moedas
// Console.WriteLine("Valor da variável condicao: " + condicao);

////Classe
// Pessoa p = new Pessoa();

// p.Nome = "Matheus";
// p.Idade = 21;
// p.Apresentar();