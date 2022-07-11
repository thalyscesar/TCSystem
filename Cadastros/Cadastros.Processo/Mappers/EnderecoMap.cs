using Cadastros.Dominio.Entidades;
using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Mappers
{
    public class EnderecoMap : ClassMapper<Endereco>
    {
        public EnderecoMap()
        {
            Schema("cadastro");
            Table("endereco");
            Map(e => e.Id).Column("id").Key(KeyType.Identity);
            Map(e => e.CEP).Column("cep");
            Map(e => e.Estado).Column("estado");
            Map(e => e.Cidade).Column("cidade");
            Map(e => e.Numero).Column("numero");
            Map(e => e.Bairro).Column("bairro");
            Map(e => e.Logradouro).Column("logradouro");
        }
    }
}
