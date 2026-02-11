using System.Text.Json;
using GerenciadorClientes.Interfaces;
using GerenciadorClientes.Models;

namespace GerenciadorClientes.Repositories
{
    public class ClienteJsonRepository : IClienteRepository
    {
        private readonly string _caminhoArquivo = "clientes.json";

        public void Adicionar(Cliente cliente)
        {
            var listaAtual = ListarTodos();
            listaAtual.Add(cliente);

            string json = JsonSerializer.Serialize(listaAtual, new JsonSerializerOptions { WriteIndented = true});


            File.WriteAllText(_caminhoArquivo, json);
            Console.WriteLine("Cliente salvo no arquivo com sucesso!");
        }

        public List<Cliente> ListarTodos()
        {
            if (!File.Exists(_caminhoArquivo))
                return new List<Cliente>();

            string json = File.ReadAllText(_caminhoArquivo);

            return JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();
        }
    }
}