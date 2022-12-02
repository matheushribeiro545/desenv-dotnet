using desenv_dotnet.Models;

//operadores - AND
/*
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/
//operadores - NOT

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}