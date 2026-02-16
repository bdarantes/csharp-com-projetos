public class Funcionario
{
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public decimal SalarioBase { get; set; }

    public Funcionario(string nome, string cpf, decimal salarioBase)
    {
        Nome = nome;
        Cpf = cpf;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

 

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome} | CPF: {Cpf}  | Recebe: R$ {CalcularSalario()}");

    }
}