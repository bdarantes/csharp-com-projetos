public class Gerente : Funcionario
{
    public decimal Bonus { get; set; }


    public Gerente(string nome, string cpf, decimal salarioBase, decimal bonus) : base(nome, cpf, salarioBase)
    {
        Bonus = bonus;
        
    }


    public override decimal CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}