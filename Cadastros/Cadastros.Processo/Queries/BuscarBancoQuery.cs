using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Queries
{
    public class BuscarBancoQuery
    {
        public Int64 Id { get; set; }
        public string? Nome { get; set; }

        public bool BancoEstaSelecionado()
        {
            return true;
        }
    }
}
