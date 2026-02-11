using GerenciadorClientes.Models;

namespace GerenciadorClientes.Interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        List<Cliente> ListarTodos();
    }
    
}