using System;


static double LerNumero(string mensagem)
{
    double numero;
    bool numeroValido;
   
    do 
    {
        Console.Write(mensagem);
        numeroValido = double.TryParse(Console.ReadLine(), out numero);

        if (!numeroValido)
        {
            Console.WriteLine("Por favor, digite um número");
        }
    } while(!numeroValido);

    return numero;



}


Console.WriteLine("+++Soma de dois números+++");
double a = LerNumero("Digite o primeiro número: ");
double b = LerNumero("Digite o segundo número: ");

Console.WriteLine($"a Soma de {a} com {b} é : {a + b}");