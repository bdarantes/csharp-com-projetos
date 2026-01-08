using System;

bool executar = true;

while (executar)
{
    
    Console.WriteLine("===Calculadora Simples===");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2- Subtração");
    Console.WriteLine("3- Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 0)
    {
        Console.WriteLine("Encerrando o programa...");
        break;
    }
    
    Console.Write("Digite o primeiro número: ");
    double numero1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double numero2 = double.Parse(Console.ReadLine());

    double resultado = 0;

    switch (opcao)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        
        case 2:
            resultado = numero1 - numero2;
            break;
        
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Erro: divisão por zero!");
                continue;
            }
            break;
        default:
            Console.WriteLine("Opção inválida!");
            continue;
    
    }
    
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado}");
    
}





