using System;

int[] numeros = {2, 3, 4, 3, 7, 8};
int contador = 0;
Console.Write("Digite um número inteiro: ");
int numeroDigitado = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i< numeros.Length; i++) 
{
    if(numeroDigitado == numeros[i]) 

    {
        contador++;
    }
       
}

if(contador >0) {
    Console.WriteLine($"O número {numeroDigitado} aparece {contador} vez(es) no array.");
}

if (!encontrado)
{
    Console.WriteLine("Número não encontrado no array.");
}