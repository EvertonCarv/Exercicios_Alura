// See https://aka.ms/new-console-template for more information
Console.WriteLine("Laços aninhados For usando Break");

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    for (int contador = 0; contador <= 10; contador++)
    {
        Console.Write($"{multiplicador} * {contador} = {multiplicador * contador}");
        Console.WriteLine();
    }
    Console.WriteLine();
}