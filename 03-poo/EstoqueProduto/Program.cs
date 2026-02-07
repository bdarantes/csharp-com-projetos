using System;
using System.Collections.Generic;
using System.Linq;


List<Produto> produtos = new List<Produto>{
    new Produto(1, "Arroz", 25.00m),
    new Produto(2, "Feijão", 5.99m),
    new Produto(3, "Macarrão", 2.99m)
};


var produtosPromocao = produtos.Where(p => p.Valor <20.00m).ToList();

foreach(var p in produtosPromocao) 
{
    Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}, Valor: {p.Valor}");
}



public class Produto 
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }


    public Produto(int id, string nome, decimal valor) 
    {
        ValidarNomeValor(nome, valor);

        Id = id;
        Nome = nome;
        Valor = valor;
    }

    public void Atualizar(string nome, decimal valor)
    {
        ValidarNomeValor(nome, valor);

        Nome = nome;
        Valor = valor;
    }

    public void ValidarNomeValor(string nome, decimal valor) {
        if(string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido.");

        if (valor <=0)
            throw new ArgumentException("Valor deve ser maior do que zero.");
    }

}