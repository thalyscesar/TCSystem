using Cadastros.Domain.Interfaces;
using Cadastros.Domain.Services;
using FluentValidation;
using MediatR;

namespace Cadastros.Application.Commands
{
    public class DeletarCliente : IRequest<bool>
    {

        public Int64 Id { get; set; }
    }

    public class ValidadorDeletarCliente : AbstractValidator<DeletarCliente>
    {
        public ValidadorDeletarCliente()
        {
            RuleFor(c => c).Must(d => new ClienteServices().ClienteExiste(d.Id)).WithMessage("Cliente não existe");
        }
    }
}
