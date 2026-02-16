using System;
using System.Collections.Generic;

Console.WriteLine("--- SISTEMA de RH ---\n");

List<Funcionario> folhaDePagamento = new List<Funcionario>();

folhaDePagamento.Add(new Funcionario("João", "111", 2000));
folhaDePagamento.Add(new Gerente("Maria", "222", 5000, 1500));
folhaDePagamento.Add(new Estagiario("Pedro", "333", 1000));


foreach (var f in folhaDePagamento)
{
    f.ExibirDados();
}