using System;

Console.WriteLine("===Calculadora Simples===");

Console.Write("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Escolha a operação: ");
Console.WriteLine("1 - Soma");
Console.WriteLine("2- Subtração");
Console.WriteLine("3- Multiplicação");
Console.WriteLine("4 - Divisão");

Console.Write("Opção: ");
int opcao = int.Parse(Console.ReadLine());

double resultado = 0;

if (opcao == 1)
{
    resultado = numero1 + numero2;
}
else if (opcao ==2)
{
    resultado = numero1 - numero2;
}

else if (opcao ==3)
{
    resultado = numero1 * numero2;
}
else if (opcao == 4)
{
    if (numero2 != 0)
    {
        resultado = numero1 / numero2;
    }
    else
    {
        Console.WriteLine("Erro: divisão por zero!");
    }
}
else
{
    Console.WriteLine("Opção inválida!");
}

Console.WriteLine();
Console.WriteLine($"Resultado: {resultado}");







