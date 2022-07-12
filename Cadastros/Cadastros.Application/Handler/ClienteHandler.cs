using Cadastros.Application.Commands;
using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;
using FluentValidation.Results;
using MediatR;

namespace Cadastros.Application.Handler
{
    public class ClienteHandler :   IRequestHandler<AdicionarCliente, bool>,
                                    IRequestHandler<AtualizarNomeCliente, bool>,
                                    IRequestHandler<DeletarCliente, bool>
    {
        private readonly IClienteServices _clienteServices;

        public ClienteHandler(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }


        //Handlers
        public Task<bool> Handle(AdicionarCliente request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var cliente = _clienteServices.Adicionar(this.ConverterParaCliente(request));
            
            return Task.FromResult(cliente);
        }

        public Task<bool> Handle(AtualizarNomeCliente request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var cliente = _clienteServices.AtualizarNome(request.Id, request.Nome);

            return Task.FromResult(cliente);
        }

        public Task<bool> Handle(DeletarCliente request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var cliente = _clienteServices.Deletar(request.Id);

            return Task.FromResult(cliente);
        }

        //Converções
        private Cliente ConverterParaCliente(AdicionarCliente adicionarCliente)
        {
            return new Cliente(0, 
                               adicionarCliente.Nome, 
                               adicionarCliente.TipoClinte, 
                               adicionarCliente.NumeroDocumento);
        }

        //Validações
        public ValidationResult ObterResultadoValidacao(AdicionarCliente adicionarCliente)
        {
            return new ValidadorAdicionarCliente().Validate(adicionarCliente);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarNomeCliente atualizarNomeCliente)
        {
            return new ValidadorAtualizarNomeCliente().Validate(atualizarNomeCliente);
        }

        public ValidationResult ObterResultadoValidacao(DeletarCliente deletarCliente)
        {
            return new ValidadorDeletarCliente().Validate(deletarCliente);
        }
    }
}
