using System;

int[] numeros = new int[5];

for (int i= 0; i< numeros.Length; i++)
{
    bool valido;
    do 
    {
        Console.Write($"Digite o {i + 1}° número: ");
        valido = int.TryParse(Console.ReadLine(), out numeros[i]);

        if(!valido)
        {
            Console.WriteLine("Valor inválido. Digite um número inteiro.");
        }
            
    } while (!valido);

}

Console.WriteLine("\nNúmeros digitados: ");

foreach (int n in numeros) 
{
    Console.WriteLine(n);
}