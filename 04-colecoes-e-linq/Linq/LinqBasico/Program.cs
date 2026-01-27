using System;

int[] numeros = {2, 3, 4, 3, 7, 8};

int quantidade = numeros.Count(n=> n ==3);

Console.WriteLine($"O número 3 aparece {quantidade} vez(es)");