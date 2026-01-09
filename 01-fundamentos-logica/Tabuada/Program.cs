using System;
using System.Reflection.Metadata;

Console.WriteLine("===Tabuada Simples===");
int numero;
bool numeroValido;
do
 {
    Console.Write("Digite um número inteiro: ");
    numeroValido = int.TryParse(Console.ReadLine(), out numero);

    if(!numeroValido) {
        Console.WriteLine("Por favor digite um número válido");
    }

}while(!numeroValido);


for(int i=0; i<=10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero*i}");
}