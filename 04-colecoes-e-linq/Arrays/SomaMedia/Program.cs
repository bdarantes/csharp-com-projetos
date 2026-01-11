using System;

int[] numeros = {10, 22, 36, 44};

int soma = 0;

foreach(int numero in numeros)
{
    soma += numero;
}

double media = (double)soma/numeros.Length;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Média: {media}");