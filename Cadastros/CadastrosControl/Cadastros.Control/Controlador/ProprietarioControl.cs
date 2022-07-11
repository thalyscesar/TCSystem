using Cadastros.Control.Commands;
using FluentValidation.Results;
using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Processo;
using Cadastros.Processo.Queries;

namespace Cadastros.Control.Controlador
{
    public class ProprietarioControl
    {
        private ProcessoProprietario processoProprietario = new ProcessoProprietario();
        private ProcessoEndereco processoEndereco = new ProcessoEndereco();
        private ProcessoBanco processoBanco = new ProcessoBanco();

        public bool Adicionar(AdicionarProprietario adicionarProprietario)
        {
            if (!this.ObterResultadoValidacao(adicionarProprietario).IsValid) return false;

            var endereco = ConverterParaEndereco(adicionarProprietario);
            var adicionarEndereco = processoEndereco.Inserir(endereco);

            var proprietario = this.ConverterParaProprietario(adicionarProprietario, (int)endereco.Id);
            return processoProprietario.Inserir(proprietario);
        }

        public List<BuscarBancoQuery> ObterBancos()
        {
            return processoBanco.BuscarBancos();
        }

        private Proprietario ConverterParaProprietario(AdicionarProprietario adicionarProprietario, int idEndereco)
        {
            Proprietario proprietario = new Proprietario(
                0,
                adicionarProprietario.Nome,
                adicionarProprietario.Telefone,
                adicionarProprietario.Celular,
                adicionarProprietario.Email,
                adicionarProprietario.CPF,
                adicionarProprietario.RG,
                adicionarProprietario.Observacao,
                idEndereco,
                (int)adicionarProprietario.IdBanco,
                adicionarProprietario.CodigoAgencia,
                adicionarProprietario.NumeroConta
                );

            return proprietario;
        }

        private Endereco ConverterParaEndereco(AdicionarProprietario adicionarProprietario)
        {
            return new Endereco(
                0,
                adicionarProprietario.CEP,
                adicionarProprietario.Cidade,
                adicionarProprietario.Estado,
                adicionarProprietario.Logradouro,
                adicionarProprietario.Numero,
                adicionarProprietario.Bairro   
                );
           
            // cep - cidade - estado - logradouro - numero - bairro
        }

        public ValidationResult ObterResultadoValidacao(AdicionarProprietario adicionarProprietario)
        {
            return new ValidadorAdicionarProprietario().Validate(adicionarProprietario);
        }
    }
}
