// See https://aka.ms/new-console-template for more information

Console.WriteLine("Condicionais if - else");



Console.WriteLine("Informe Sua Idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe Quantidade Pessoas?");
int quantidadePessoas = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você tem mais que 18 anos.");
    Console.WriteLine("Seja Bem Vindo");
}
else
{
    if (quantidadePessoas >= 2)
    {
        Console.WriteLine("Você não tem 18 anos, mas pode entrar," 
            +          " pois está acompanhado");
    }
    else
    {
        Console.WriteLine("Infelizmente você não pode entrar");
    }
}
   
