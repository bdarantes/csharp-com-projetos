using System;

static double lerNumero()
{
    Console.Write("Digite um número: ");
    bool numeroValido = double.TryParse(Console.ReadLine(), out double numero);
    return numero;
}

Console.WriteLine("Você irá digitar 2 números para serem somados");
double a = lerNumero();
double b = lerNumero();

Console.WriteLine($"A soma entre {a} e {b} é: {a + b}");