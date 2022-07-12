using Cadastros.Domain.Enuns;
using FluentValidation;
using MediatR;

namespace Cadastros.Application.Commands
{
    public class AdicionarCliente : IRequest<bool>
    {
        public string? Nome { get; set; }
        public TipoClinte TipoClinte { get; set; }
        public string? NumeroDocumento { get; set; }
    }

    public class ValidadorAdicionarCliente : AbstractValidator<AdicionarCliente>
    {
        public ValidadorAdicionarCliente()
        {
            RuleFor(a => a.Nome).NotEmpty().NotNull().WithMessage("o campo Nome não pode ser nulo ou vazio");
            RuleFor(a => a.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo Nome deve conter de 10 a 50 caracteres");
            RuleFor(a => a.TipoClinte).NotNull().WithMessage("O campo TipoCliente não pode ser nulo");
            RuleFor(a => a.NumeroDocumento).NotEmpty().NotNull().WithMessage("O campo NumeroDocumento não pode ser nulo ou vazio");
            RuleFor(a => a.NumeroDocumento).MinimumLength(11).MaximumLength(15).WithMessage("O campo NumeroDocumento deve coter de 11 a 15 caracteres");
        }
    }
}
