using Cadastros.Core.Infra.Interfaces;
using Cadastros.Domain.Entities;

namespace Cadastros.Domain.Interfaces
{
    public interface IRepositorioCliente : IRepositorioBase<Cliente>
    {
        bool AtualizarNome(Int64 id, string nome);
    }
}
