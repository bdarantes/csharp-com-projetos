namespace GerenciadorClientes.Models;

public class Endereco
{
    public string? Logradouro { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; }
    public string? Uf { get; set; }

}

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Cep { get; set; }
    public Endereco? EnderecoCompleto { get; set; }
}