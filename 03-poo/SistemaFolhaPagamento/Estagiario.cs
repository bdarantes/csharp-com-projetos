public class Estagiario : Funcionario
{
    public Estagiario(string nome, string cpf, decimal salarioBase) : base(nome, cpf, salarioBase)
    {
        
    }

    public override decimal CalcularSalario()
    {
        return SalarioBase * 0.80m;
    }
}