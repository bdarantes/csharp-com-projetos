using System;
using System.Collections.Generic;
using System.Linq;


Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Produto> estoque = new List<Produto>
{
    new Produto(1, "Notebook Gamer", 4500.00m),
    new Produto(2, "Mouse Sem Fio", 50.00m),
    new Produto(3, "Teclado Mecânico", 150.00m),
    new Produto(4, "Monitor 24pol", 800.00m),
    new Produto(5, "Cabo HDMI", 25.00m),
    new Produto(6, "Cadeira Ergonômica", 1200.00m)
};

Console.WriteLine($"Estoque carregado com {estoque.Count} produtos");
Console.WriteLine("---------------");

var produtosCaros = estoque.Where(p => p.Valor > 1000).ToList();

Console.WriteLine("Produtos de Luxo:");
foreach (var p in produtosCaros)
{
    Console.WriteLine($"-{p.Nome} : R$ {p.Valor:F2}");
}

public class Produto{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }


    public Produto(int id, string nome, decimal valor) {

        if(string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido");

        if (valor <=0)
            throw new ArgumentException("Valor deve ser maior do que zero");
        Id = id;
        Nome = nome;
        Valor = valor;

    }

    public void Atualizar(string novoNome, decimal novoValor)
    {
        if(string.IsNullOrWhiteSpace(novoNome))
            throw new ArgumentException("Nome inválido");

        if (novoValor <=0)
            throw new ArgumentException("Valor deve ser maior do que zero");

        Nome = novoNome;
        Valor = novoValor;

    }



}