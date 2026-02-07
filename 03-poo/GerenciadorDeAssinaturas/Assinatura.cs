using System;

public enum Categoria { Streaming, Servico, Software, Academia }

public class Assinatura {
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }
    public Categoria Categoria { get; private set; }
    public DateTime DataVencimento { get; private set; }

    public Assinatura(int id, string nome, decimal valor, Categoria categoria, DateTime vecimento)
    {
        Id = id;
        Nome = nome;
        Categoria = categoria;
        DataVencimento = vecimento;
    }
}