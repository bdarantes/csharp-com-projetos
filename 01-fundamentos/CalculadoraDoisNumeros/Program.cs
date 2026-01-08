using System;


while (true)
{
    Console.WriteLine("==Calculadora Simples==");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    Console.Write("Escolha uma opção: ");
    bool opcaoValida = int.TryParse(Console.ReadLine(), out int opcao);

    if(!opcaoValida)
    {
        Console.WriteLine("Digite apenas números.");
        Console.WriteLine();
        continue;
    }

    if (opcao ==0)
    {
        Console.WriteLine("Encerrando o programa...");
        break;
    }

    if (opcao <1 || opcao >4)
    {
        Console.WriteLine("Opção inválida.");
        Console.WriteLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    bool n1Valido = double.TryParse(Console.ReadLine(), out double n1);

    Console.Write("Digite o segundo número: ");
    bool n2Valido = double.TryParse(Console.ReadLine(), out double n2);

    if (!n1Valido || !n2Valido)
    {
        Console.WriteLine("Digite apenas númers válidos.");
        Console.WriteLine();
        continue;
    }

    double resultado = 0;

    switch (opcao)
    {
        case 1:
            resultado = n1 + n2;
            break;
        
        case 2:
            resultado = n1 - n2;
            break;

        case 3:
            resultado = n1 * n2;
            break;
        case 4:
            if (n2 ==0)
            {
                Console.WriteLine("Erro: Não existe divisão por zero");
                Console.WriteLine();
                continue;
            }

            resultado = n1 / n2;
            break;
        

    }

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine();

}