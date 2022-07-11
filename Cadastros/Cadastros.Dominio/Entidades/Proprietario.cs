using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Dominio.Entidades
{
    public class Proprietario: Entity
    {
        public Proprietario(Int64 id, string? nome, string? telefone, string? celular, string? email, string? cPF, string? rg, string? observacao, int endereco, int banco, string? codigoAgencia, string? numeroConta) : base(id)
        {
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            CPF = cPF;
            RG = rg;
            Observacao = observacao;
            IdEndereco = endereco;
            IdBanco = banco;
            CodigoAgencia = codigoAgencia;
            NumeroConta = numeroConta;
        }

        public string? Nome { get; private set; }
        public string? Telefone { get; private set; }
        public string? Celular { get; private set; }
        public string? Email { get; private set; }
        public string? CPF { get; private set; }
        public string? RG { get; private set; }
        public string? Observacao { get; private set; }
        public int IdEndereco { get; private set; }
        public int IdBanco { get; private set; }
        public string? CodigoAgencia { get; private set; }
        public string? NumeroConta { get; private set; }
    }
}
