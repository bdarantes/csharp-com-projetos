using System;

static double lerNumero()
{
    double numero;
    bool numeroValido;

    do 
    {
        Console.Write("Digite um número: ");
        numeroValido = double.TryParse(Console.ReadLine(), out numero);

        if(!numeroValido) {
            Console.WriteLine("Por favor digite um número válido");
        }
        
    } while(!numeroValido);
    
    return numero;
}

Console.WriteLine("Você irá digitar 2 números para serem somados");
double a = lerNumero();
double b = lerNumero();

Console.WriteLine($"A soma entre {a} e {b} é: {a + b}");