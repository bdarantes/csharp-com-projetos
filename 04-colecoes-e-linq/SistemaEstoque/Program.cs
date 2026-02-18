using System;
using System.Collections.Generic;

Dictionary<string, double> estoque = new Dictionary<string, double>();


estoque.Add("Teclado", 150.00);
estoque["Mouse"] = 80.50;

string busca = "Mouse";

if(estoque.ContainsKey(busca))
{
    Console.WriteLine($"O preço do {busca} é: R$ {estoque[busca]}");
}