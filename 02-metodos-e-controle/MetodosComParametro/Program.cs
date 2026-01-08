using System;
using System.Reflection.Metadata;

static double LerNumero(string mensagem)
{
    Console.Write(mensagem);
    bool numeroValido = double.TryParse(Console.ReadLine(), out double numero);
    return numero;
}
Console.WriteLine("+++Soma de dois números+++");
double a = LerNumero("Digite o primeiro número: ");
double b = LerNumero("Digite o segundo número: ");

Console.WriteLine($"a Soma de {a} com {b} é : {a + b}");