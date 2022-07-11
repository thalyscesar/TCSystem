using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Dominio.Entidades
{
    public class Banco : Entity
    {

        public Banco()
        {

        }

        public Banco(Int64 id, string? nome): base(id) 
        {
            Nome = nome;
        }

        public string? Nome { get; private set; }
    }
}
