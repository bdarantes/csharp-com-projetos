using System;

int [] numeros = {3, 2, 8, 4, 7};

int maior = numeros[0];
int menor = numeros[0];

foreach (int numero in numeros)
{
    if (numero > maior) 
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }

    
    Console.WriteLine(numero);
}


Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Menor valor: {menor}");