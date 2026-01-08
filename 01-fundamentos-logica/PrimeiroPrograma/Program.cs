using System;

Console.WriteLine("===Cadastro Simples====");

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá {nome}, você tem {idade} anos");