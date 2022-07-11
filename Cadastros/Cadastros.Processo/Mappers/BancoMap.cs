using Cadastros.Dominio.Entidades;
using DapperExtensions.Mapper;

namespace Cadastros.Processo.Mappers
{
    public class BancoMap : ClassMapper<Banco>
    {
        public BancoMap()
        {
            Schema("cadastro");
            Table("banco");
            Map(b => b.Id).Column("id").Key(KeyType.Identity);
            Map(b => b.Nome).Column("nome");
            
            //AutoMap();
        }
    }
}
