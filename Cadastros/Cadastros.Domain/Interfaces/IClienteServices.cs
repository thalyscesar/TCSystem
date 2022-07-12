using Cadastros.Domain.Entities;

namespace Cadastros.Domain.Interfaces
{
    public interface IClienteServices
    {
        bool Adicionar(Cliente cliente);
        bool Deletar(Int64 id);
        bool AtualizarNome(Int64 id, string nome);
        List<Cliente> Obtertodos();
        Cliente ObterPorId(Int64 id);
    }
}
