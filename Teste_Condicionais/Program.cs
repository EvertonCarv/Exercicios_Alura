// See https://aka.ms/new-console-template for more information
Console.WriteLine("Teste_Condicional");
/*
int idade = 18;
int quantidadePessoas = 2;*/

Console.WriteLine("Informe sua Idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe número de pessoas?");
int quantidadePessoas = int.Parse(Console.ReadLine());

if (idade >= 18 || quantidadePessoas >= 2)
{
    Console.WriteLine("Seja bem vindo");
}
else
{
    Console.WriteLine("infelizmente voce nao pode entrar");
}
