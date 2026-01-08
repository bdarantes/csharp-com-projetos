using System;
using System.Reflection.Metadata;

Console.WriteLine("===Tabuada Simples===");

Console.Write("Digite um número inteiro: ");
 bool numeroValido = int.TryParse(Console.ReadLine(), out int numero);

for(int i=0; i<=10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero*i}");
}