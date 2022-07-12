using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;

namespace Cadastros.Domain.Services
{
    public class ClienteServices : IClienteServices
    {
        public ClienteServices()
        {

        }

        private readonly IRepositorioCliente _repositorioCliente;

        public ClienteServices(IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
        }

        public bool Adicionar(Cliente cliente)
        {
            return _repositorioCliente.Inserir(cliente) > 0;
        }

        public bool AtualizarNome(long id, string nome)
        {
            return _repositorioCliente.AtualizarNome(id, nome);
        }

        public bool Deletar(long id)
        {
            var cliente = _repositorioCliente.BuscarPorId(id);

            return _repositorioCliente.Excluir(cliente);
        }

        public Cliente ObterPorId(long id)
        {
            return _repositorioCliente.BuscarPorId(id);
        }

        public List<Cliente> Obtertodos()
        {
            throw new NotImplementedException();
        }

        //Validações
        public bool ClienteExiste(Int64 id)
        {
            var cliente = new Cliente();
            cliente = _repositorioCliente.BuscarPorId(id);

            if(cliente == null) return false;

            return cliente.Id > 0;
        }
    }
}
