public class Produto
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Valor {get; private set; }

    public Produto(int id, string nome, decimal valor)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido.");

        if (valor <=0)
        
            throw new ArgumentException("Valor deve ser maior que zero.");

        Id = id;
        Nome = nome;
        Valor = valor; 
    }

    public void Atualizar(string nome, decimal valor)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido.");

        if (valor <= 0)
            throw new ArgumentException("Valor deve ser maior do que zero.");

            Nome = nome;
            Valor = valor;
    }
}