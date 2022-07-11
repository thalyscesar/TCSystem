using Cadastros.Processo.Processo;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Control.Commands.Banco
{
    public class AdicionarBanco
    {
        public Int64 Id { get; set; }
        public string? Nome { get; set; }
    }

    public class ValidadorAdicionarBanco : AbstractValidator<AdicionarBanco>
    {
        public ValidadorAdicionarBanco()
        {
            RuleFor(b => b).Must(b => !new ProcessoBanco().BancoExiste(b.Nome)).WithMessage("Banco já cadastrado");
            RuleFor(a => a.Nome).NotNull().NotEmpty().WithMessage("Informe o nome do banco");
        }
    }

}
