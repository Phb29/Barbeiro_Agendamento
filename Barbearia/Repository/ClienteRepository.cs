using Barbearia.BdContext;
using Barbearia.Models;
using Barbearia.Repository.Interface;

namespace Barbearia.Repository
{
    public class ClienteRepository:IClienteRepository
    {
        private readonly Context _context;

        public ClienteRepository(Context context)
        {
            _context = context;
        }
        
        public IEnumerable<Cliente> Clientes => _context.Clientes;

        public Cliente ClienteID(int id) => _context.Clientes.FirstOrDefault(x => x.IdCliente == id)!;
        
    }
}
