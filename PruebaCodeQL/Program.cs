// See https://aka.ms/new-console-template for more information

//https://www.youtube.com/watch?v=NjQ9covhknY           //Solucion a error de autobuild
//https://www.youtube.com/watch?v=9xWW0BwopDk
//https://learn.microsoft.com/es-es/dotnet/core/tools/sdk-errors/netsdk1005
//https://stphnwlsh.medium.com/using-github-actions-to-update-net-dependencies-automatically-d555f629fed0

//Tutorial
//https://codeql.github.com/docs/writing-codeql-queries/ql-tutorials/

//TODO: Esto es un TO DO

Console.WriteLine("Hello, World!");
Authenticate("usuario", "password");

int suma = Suma(1, 2);
Console.WriteLine("La suma es :" + suma);



void Authenticate(string user, string password)
{
    Console.WriteLine("el pass es:" + password);
}



int Suma(int numA, int numB)
{
    return numA + numB;
}

/* Codigo comentado
int Suma(int numA, int numB)
{
    return numA + numB;
}
*/