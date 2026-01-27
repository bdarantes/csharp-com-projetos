using System;
using System.Collections.Generic;


List<Produto> produtos = new();
int proximoId = 1;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== CRUD DE PRODUTOS ===");
    Console.WriteLine("1- Cadastrar");
    Console.WriteLine("2- Listar");
    Console.WriteLine("3- Atualizar");
    Console.WriteLine("4- Remover");
    Console.WriteLine("0- Sair");
    Console.Write("Opção: ");

    var opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                CadastrarProduto();
                break;
            case "2":
                ListarProdutos();
                break;
            case "3":
                AtualizarProduto();
                break;
            case "4":
                RemoverProduto();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opção inválida.");
                Pausar();
                break;
        }
    }
    catch (Exception ex)
    {
        
        Console.WriteLine($"Erro: {ex.Message}");
        Pausar();
    }
}

void CadastrarProduto()
{
    Console.Write("Nome: ");
    var nome = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(nome))
        throw new Exception("Nome é obrigatório");

    Console.Write("Valor: ");
    var entradaValor = (Console.ReadLine());

    if(!decimal.TryParse(entradaValor, out decimal valor))
        throw new Exception("Valor inválido");

    var produto = new Produto(proximoId++, nome!, valor);
    produtos.Add(produto);

    Console.WriteLine("Produto cadastrado com sucesso!");
    Pausar();

}

void ListarProdutos()
{
    if(produtos.Count ==0)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
        Pausar();
        return;
    }

    foreach (var produto in produtos)
    {
        Console.WriteLine($"{produto.Id} - {produto.Nome} - R$ {produto.Valor}");

    }

    Pausar();
    
}

void AtualizarProduto()
{
    Console.Write("ID do produto: ");
    var entradaId = (Console.ReadLine());

    if(!int.TryParse(entradaId, out int id))
        throw new Exception("ID inválido");

    var produto = BuscarProdutoPorId(id);
    if(produto == null)
        throw new Exception("Produto não encontrado.");

    Console.Write("Novo nome: ");
    var nome = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(nome))
        throw new Exception("Nome é obrigatório.");
    
    Console.Write("Novo valor: ");
    var entradaValor = Console.ReadLine();

    if(!decimal.TryParse(entradaValor, out decimal valor))
        throw new Exception("Valor inválido.");

    produto.Atualizar(nome, valor);

    Console.WriteLine("Produto atualizado!");
    Pausar();


}

void RemoverProduto()
{
    Console.Write("ID do produto: ");
    var entradaId = Console.ReadLine();

    if(!int.TryParse(entradaId, out int id))
        throw new Exception("ID inválido.");

    var produto = BuscarProdutoPorId(id);
    if(produto == null) 
        throw new Exception("Produto não encontrado.");

    produtos.Remove(produto);

    Console.WriteLine("Produto removido!");
    Pausar();
}

Produto? BuscarProdutoPorId(int id)
{
    foreach (var produto in produtos)
    {
        if (produto.Id == id)
            return produto;
    }

    return null;
}


void Pausar()
{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey(true);
}

