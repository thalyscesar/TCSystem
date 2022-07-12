using Cadastros.Application.Commands;
using Cadastros.Application.Handler;
using Cadastros.Domain.Interfaces;
using Cadastros.Domain.Services;
using Cadastros.Infra.Data.Repositorios;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ioc
{
    public static class InjectorBootStrapper
    {
        public static void AddContainerServices(this IServiceCollection services)
        {
            AddServices(services);
            AddConfigHandlers(services);
            AddConfigRepositorios(services);

        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IClienteServices, ClienteServices>();
        }

        private static void AddConfigHandlers(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<AdicionarCliente, bool>, ClienteHandler>();
            services.AddScoped<IRequestHandler<AtualizarNomeCliente, bool>, ClienteHandler>();
            services.AddScoped<IRequestHandler<DeletarCliente, bool>, ClienteHandler>();
        }

        private static void AddConfigRepositorios(IServiceCollection services)
        {
            services.AddScoped<IRepositorioCliente, RepositorioCliente>();
        }
    }
}