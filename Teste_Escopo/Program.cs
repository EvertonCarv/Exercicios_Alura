// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int idade = 20;
int quantidadePessoas = 3;
bool acompanhado = true;

if (quantidadePessoas >= 2)
{
    acompanhado = true;
}
else
{
    acompanhado = false;
}

if (idade >= 18 || acompanhado)
{
    Console.WriteLine("Seja bem vindo");
}
else
{
    Console.WriteLine("infelizmente voce nao pode entrar");
}