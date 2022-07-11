using Cadastros.Processo.Processo;
using FluentValidation;
namespace Cadastros.Control.Commands
{
    public class AdicionarProprietario
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? Observacao { get; set; }
        public long IdBanco { get; set; }
        public string? CodigoAgencia { get; set; }
        public string? NumeroConta { get; set; }
        public string? CEP { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }


    }

    public class ValidadorAdicionarProprietario : AbstractValidator<AdicionarProprietario>
    {
        public ValidadorAdicionarProprietario()
        {
            RuleFor(p => p).Must(b => !new ProcessoProprietario().ProprietarioExiste(b.CPF)).WithMessage("Pessoa já cadastrado");
            RuleFor(p => p.Nome).NotNull().NotEmpty().WithMessage("Informe o nome");
            RuleFor(p => p.Nome).MinimumLength(12).MaximumLength(50).WithMessage("{Nome} deve ter entre 12 e 50 caracteres");
            RuleFor(p => p.Telefone).NotNull().NotEmpty().WithMessage("Informe o telefone");
            RuleFor(p => p.Celular).NotNull().NotEmpty().WithMessage("Informe o celular");
            RuleFor(p => p.CPF).NotNull().NotEmpty().WithMessage("Informe o CPF");
            RuleFor(p => p.RG).NotNull().NotEmpty().WithMessage("Informe o RG");
            RuleFor(p => p.Email).NotNull().NotEmpty().WithMessage("Informe o Email");
            RuleFor(p => p.Observacao).NotNull().NotEmpty().WithMessage("Informe uma informação");
            RuleFor(p => p.IdBanco).NotNull().NotEmpty().WithMessage("Informe o banco");
            RuleFor(p => p.CodigoAgencia).NotNull().NotEmpty().WithMessage("Informe o código da agência");
            RuleFor(p => p.NumeroConta).NotNull().NotEmpty().WithMessage("Informe o número da conta");
            RuleFor(e => e.CEP).NotNull().NotEmpty().WithMessage("Informe o CEP");
            RuleFor(e => e.Cidade).NotNull().NotEmpty().WithMessage("Informe a cidade");
            RuleFor(e => e.Estado).NotNull().NotEmpty().WithMessage("Informe o estado");
            RuleFor(e => e.Logradouro).NotNull().NotEmpty().WithMessage("Informe o logradouro ou rua");
            RuleFor(e => e.Numero).NotNull().NotEmpty().WithMessage("Informe o número");
            RuleFor(e => e.Bairro).NotNull().NotEmpty().WithMessage("Informe o bairro");
        }
    }
}
