using Cadastros.Domain.Entities;
using DapperExtensions.Mapper;

namespace Cadastros.Infra.Data.Maps
{
    public class ClienteMap : ClassMapper<Cliente>
    {
        public ClienteMap()
        {
            Table("cliente");
            Schema("cadastros");
            Map(c => c.Id).Column("id").Key(KeyType.Identity);
            Map(c => c.Nome).Column("nome");
            Map(c => c.TipoClinte).Column("tipocliente");
            Map(c => c.NumeroDocumento).Column("numerodocumento");
        }
    }
}
