using System;
using System.Linq;
using System.Runtime.CompilerServices;

AssinaturaRepository repository = new AssinaturaRepository();

while (true)
{
    Console.Clear();
    Console.WriteLine("===Gerenciador de Assinaturas (Gastos Recorrentes)===");

    var totalMensal = repository.ListarTodas().Sum(a => a.Valor);
    Console.WriteLine($"Gasto Total Mensal: R$ {totalMensal:F2}\n");

    Console.WriteLine("1. Adicionar Assinatura");
    Console.WriteLine("2. Listar Minhas Assinaturas");
    Console.WriteLine("3. Filtrar por Categoria");
    Console.WriteLine("0. Sair");
    Console.Write("Opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            AdicionarNova(repository);
            break;
        case "2":
            Listar(repository);
            break;
        case "3":
            FiltrarPorCategoria(repository);
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
}

static void AdicionarNova(AssinaturaRepository repository)
{
    Console.WriteLine("\n--- Nova Assinatura---");
    Console.WriteLine("\nNome (ex: Netflix): ");
    string nome = (Console.ReadLine() ?? "");

    Console.WriteLine("Valor(Use VÍRGULA, ex: 25,90): ");
    if(!decimal.TryParse(Console.ReadLine(), out decimal valor))
    {
        Console.WriteLine("Valor inválido! Tente novamente.");
        Console.ReadKey();
        return;
    }
    
    Console.WriteLine("\nCategoria:");
    Console.WriteLine("0 - Streaming");
    Console.WriteLine("1 - Serviço");
    Console.WriteLine("2 - Software");
    Console.WriteLine("3 - Academia");
    Console.Write("Escolha o número: ");

    if (int.TryParse(Console.ReadLine(), out int tipoCategoria))
    {
        Categoria categoriaEscolhida = (Categoria)tipoCategoria;

        int novoId = repository.ListarTodas().Count +1;

        var nova = new Assinatura(novoId, nome, valor, categoriaEscolhida, DateTime.Now.AddDays(30));

        repository.Adicionar(nova);
        Console.WriteLine("Salvo com sucesso!");
    }
    else
    {
        Console.WriteLine("Categoria inválida!");
    }

    Console.ReadKey();


    

   
}

static void Listar(AssinaturaRepository repository)
{
    Console.WriteLine("\n--- Lista ---");
    foreach (var item in repository.ListarTodas())
    {
        Console.WriteLine($"{item.Nome} - R$ {item.Valor:F2}");
    }
    Console.ReadKey();
}

static void FiltrarPorCategoria(AssinaturaRepository repository)
{
    Console.WriteLine("\n--- Filtrar ---");
    Console.WriteLine("0-Streaming | 1-Serviço | 2-Software | 3-Academia");
    Console.Write("Qual categoria deseja ver? ");

    if(int.TryParse(Console.ReadLine(), out int opcao))
    {
        Categoria cat = (Categoria)opcao;

        var filtradas = repository.ListarTodas()
                                  .Where(a => a.Categoria == cat)
                                  .ToList();

        if(filtradas.Count == 0)
        {
            Console.WriteLine("Nenhuma assinatura encontrada nessa categoria");
        }
         else
        {
            Console.WriteLine($"\nExibindo gastos com {cat}");
            foreach (var item in filtradas)
            {
                Console.WriteLine($"- {item.Nome}: R$ {item.Valor:F2}");
            }

            var totalCategoria = filtradas.Sum(x => x.Valor);
            Console.WriteLine($"Total nesta categoria: R$ {totalCategoria:F2}");

        }
    }

    Console.ReadKey();
}