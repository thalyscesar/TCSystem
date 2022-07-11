using Cadastros.Dominio.Entidades;
using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Mappers
{
    public class ProprietarioMap: ClassMapper<Proprietario>
    {
        public ProprietarioMap()
        {
            //ToTable("cadastro.proprietario");

            Table("proprietario");
            Schema("cadastro");
            Map(p => p.Nome).Column("nome");
            Map(p => p.Telefone).Column("telefone");
            Map(p => p.Celular).Column("celular");
            Map(p => p.Email).Column("email");
            Map(p => p.CPF).Column("cpf");
            Map(p => p.RG).Column("rg");
            Map(p => p.Observacao).Column("observacao");
            Map(p => p.CodigoAgencia).Column("codigoagencia");
            Map(p => p.NumeroConta).Column("numeroconta");
            Map(p => p.IdEndereco).Column("id_endereco");
            Map(p => p.IdBanco).Column("id_banco");
            Map(p => p.Id).Column("id").Key(KeyType.Identity);
        }

        public PropertyInfo GetPropertyInfo(Expression<Func<Proprietario,object>> expression)
        {
            MemberExpression memberExpression = (MemberExpression)expression.Body;
            return (PropertyInfo)memberExpression.Member;


        } 
    }
}
