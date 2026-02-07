Funcionario f = new Funcionario();
f.Nome = "Pedro";
f.Salario = 2000.00m;

Gerente g = new Gerente();
g.Nome = "Ana";
g.Salario = 5000.00m;


Console.WriteLine($"Bônus do Pedro: {f.CalcularBonificacao():F2}");
Console.WriteLine($"Bônus da Ana: {g.CalcularBonificacao():F2}");

public class Funcionario 
{
    public string? Nome { get; set; }
    public decimal Salario { get; set; }

    public virtual decimal CalcularBonificacao() {
        return Salario * 0.10m;
    }
}


public class Gerente : Funcionario 
{
    public override decimal CalcularBonificacao() {
        return Salario * 0.20m + 100.00m;
    }
}