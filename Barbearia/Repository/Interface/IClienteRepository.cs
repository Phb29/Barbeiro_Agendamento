using Barbearia.Models;

namespace Barbearia.Repository.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Clientes { get; }
        
        Cliente ClienteID(int id);
    }
}
