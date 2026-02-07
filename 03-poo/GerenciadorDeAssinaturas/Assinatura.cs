using System.Text.Json.Serialization;
using System;

public enum Categoria { Streaming, Servico, Software, Academia }

public class Assinatura {
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }
    public Categoria Categoria { get; private set; }
    public DateTime DataVencimento { get; private set; }


    [JsonConstructor]
    public Assinatura(int id, string nome, decimal valor, Categoria categoria, DateTime dataVencimento)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
        Categoria = categoria;
        DataVencimento = dataVencimento;
    }
}