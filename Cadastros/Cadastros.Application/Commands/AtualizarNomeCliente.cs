using FluentValidation;
using MediatR;

namespace Cadastros.Application.Commands
{
    public class AtualizarNomeCliente : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public string? Nome { get; set; }
    }

    public class ValidadorAtualizarNomeCliente : AbstractValidator<AtualizarNomeCliente>
    {
        public ValidadorAtualizarNomeCliente()
        {
            RuleFor(c => c.Id).NotEmpty().NotNull().WithMessage("O campo Id não pode ser nulo ou vazio");
            RuleFor(c => c.Nome).NotNull().NotEmpty().WithMessage("O campo Nome não pode ser nulo ou vazio");
            RuleFor(c => c.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo nome deve conter de 10 a 50 caracteres");
        }
    }
}
