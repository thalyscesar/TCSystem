using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Queries
{
    public class BuscarEnderecoQuery
    {
        public Int64 Id { get; set; }
        public string? CEP { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public int IdBanco { get; set; }
        public int IdEndereco { get; set; }
    }
}
