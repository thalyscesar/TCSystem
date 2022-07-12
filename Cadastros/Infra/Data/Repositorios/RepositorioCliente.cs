using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;
using Cadastros.Infra.Data.Maps;
using Shared.Data;

namespace Cadastros.Infra.Data.Repositorios
{
    public class RepositorioCliente : RepositorioBase<Cliente, ClienteMap>, IRepositorioCliente
    {
        public bool AtualizarNome(long id, string nome)
        {
            var query = $"UPDATE cadastros.cliente SET nome = '{nome}' WHERE id = {id};";

            var resultadoAtualizacao = DBHelper<Cliente>.InstanciaNpgsql.Get(query);

            return resultadoAtualizacao != null;
        }
    }
}
