using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Dominio.Entidades
{
    public class Endereco : Entity
    {

        public Endereco()
        {

        }

        public Endereco(Int64 id, string? cEP, string? cidade, string? estado, string? logradouro, string? numero, string? bairro) : base(id)
        {
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
        }

        public string? CEP { get; private set; }
        public string? Cidade { get; private set; }
        public string? Estado { get; private set; }
        public string? Logradouro { get; private set; }
        public string? Numero { get; private set; }
        public string? Bairro { get; private set; }

        // cep - cidade - estado - logradouro - numero - bairro
    }
}
