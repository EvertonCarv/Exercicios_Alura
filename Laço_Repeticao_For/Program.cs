// See https://aka.ms/new-console-template for more information
Console.WriteLine("Laço repetição For");


// Contador
/*for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine(contador);
}*/


// Tabuada completa
/*for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    for (int contador = 0; contador <= 10; contador++)
    {
        Console.Write($"{multiplicador} * {contador} = {multiplicador * contador}");
        Console.WriteLine();
    }
    Console.WriteLine();
}*/


// Fazendo Desenho *
for (int linha = 0; linha < 10; linha++)
{
    for (int coluna = 0; coluna < 10; coluna++)
    {
        if (coluna > linha)
        {
            break;
        }
        Console.Write("*");
    }
    Console.WriteLine();
}