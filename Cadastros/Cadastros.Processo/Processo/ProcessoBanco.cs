using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Base;
using Cadastros.Processo.Queries;
using Cadastros.Processo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Processo
{
    public class ProcessoBanco : ProcessoCadastroBase <Banco, RepositorioBanco>
    {
        public bool BancoExiste(string? nome)
        {
            return Repositorio.BancoExiste(nome);
        }

        public List<BuscarBancoQuery> BuscarBancos(string inicial)
        {
            return Repositorio.BuscarBancos(inicial);
        }

        public BuscarBancoQuery BuscarBanco(string? nome)
        {
            return Repositorio.BuscarBanco(nome);
        }

        public List<BuscarBancoQuery> BuscarBancos()
        {
            return Repositorio.BuscarBancos("");
        }


    }
}
