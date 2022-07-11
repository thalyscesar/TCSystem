using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Mappers;
using Cadastros.Processo.Queries;
using Shared.Data;
using Shared.Repositorio;

namespace Cadastros.Processo.Repositorio
{
    public class RepositorioEndereco : RepositorioCadastroBase<Endereco, EnderecoMap>
    {
        public BuscarBancoQuery InserirEndereco(Endereco endereco)
        {
            string querySelect = string.Format("INSERT INTO cadastro.endereco (cep, cidade, estado, logradouro, numero, bairro)" +
                                                "VALUES('', 'Rondis', 'Maranhão', 'Rua das Olindas', '12', 'Trize'); ");
            return null;
        }
    }
}
