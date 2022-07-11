using Cadastros.Control.Commands.Banco;
using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Processo;
using Cadastros.Processo.Queries;
using FluentValidation.Results;

namespace Cadastros.Control.Controlador
{
    public class BancoControl
    {
        private ProcessoBanco processoBanco = new ProcessoBanco();
        public bool Adicionar(AdicionarBanco adicionarBanco)
        {
            if (!this.ObterResultadoValidacao(adicionarBanco).IsValid) return false;

            Banco banco = new Banco(0,adicionarBanco.Nome);

            return processoBanco.Inserir(banco);
        }

        public bool Atualizar(AtualizarBanco atualizarBanco)
        {
            if (atualizarBanco != null && !atualizarBanco.PodeAtualizar()) return false;

            var banco = new Banco(atualizarBanco.Id, atualizarBanco.Nome);

            return processoBanco.Atualizar(banco);
        }

        public bool Excluir(BuscarBancoQuery buscarBancoQuery)
        {
            if(buscarBancoQuery != null && !buscarBancoQuery.BancoEstaSelecionado()) return false;

            return processoBanco.Excluir(new Banco(buscarBancoQuery.Id, buscarBancoQuery.Nome));
        }

        public List<BuscarBancoQuery> BuscarBancoQueries(string inicial)
        {  
            return processoBanco.BuscarBancos(inicial).ToList();
        }

        public ValidationResult ObterResultadoValidacao(AdicionarBanco adicionarBanco)
        {
            return new ValidadorAdicionarBanco().Validate(adicionarBanco);
        }
    }
}
