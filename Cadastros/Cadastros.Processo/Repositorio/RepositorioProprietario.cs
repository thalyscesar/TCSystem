using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Mappers;
using Shared.Data;
using Shared.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Repositorio
{
    public class RepositorioProprietario: RepositorioCadastroBase<Proprietario, ProprietarioMap>
    {
        public bool ProprietarioExiste(string cpf)
        {
            string querySelect = string.Format("SELECT count(*) FROM cadastro.proprietario WHERE cpf = '{0}';", cpf);

            return DBHelper<Proprietario>.InstanciaNpgsql.Get(querySelect) > 0;
        }
    }
}
