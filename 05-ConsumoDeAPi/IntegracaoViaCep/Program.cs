using System;

Console.WriteLine("===Integração Via Cep - Iniciando===");

ViaCepService service = new ViaCepService();

while (true)
{
    Console.Write("\nDigite o CEP (ou 'sair): ");
    string cepInput = Console.ReadLine() ?? "";

if (string.IsNullOrWhiteSpace(cepInput) || cepInput.ToLower() == "sair")
    break;

Console.WriteLine("Buscando....");

Endereco? endereco = await service.BuscarEndereco(cepInput);

if (endereco == null || endereco.Erro == "true")
    {
        Console.WriteLine("CEP não encontrado!");
    }
else
    {
        Console.WriteLine("Endereço Localizado:");
        Console.WriteLine($"-> {endereco.Logradouro}");
        Console.WriteLine($"-> {endereco.Bairro}");
        Console.WriteLine($"-> {endereco.Cidade} - {endereco.Uf}");
        
    }
}

Console.WriteLine("=== Encerrando Integração Via Cep ===");