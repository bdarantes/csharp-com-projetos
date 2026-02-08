using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class ViaCepService
{
    private static readonly HttpClient _client = new HttpClient();

    public async Task<Endereco> BuscarEndereco(string cep)
    {
        try
        {
            if (cep.Length != 8)
                return null;

            string url = $"https://viacep.com.br/ws/{cep}/json/";

            HttpResponseMessage response = await _client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
            var endereco = JsonSerializer.Deserialize<Endereco>(jsonString, options);

            return endereco;
        }

        catch (HttpRequestException e)
        {
            
            Console.WriteLine($"Erro de rede: {e.Message}");
            return null;
        }
        catch (JsonException e)
        {
            Console.WriteLine($"Erro ao ler JSON: {e.Message}");
            return null;
        }
    }
    
}