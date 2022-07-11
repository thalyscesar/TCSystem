using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Base;
using Cadastros.Processo.Queries;
using Cadastros.Processo.Repositorio;

namespace Cadastros.Processo.Processo
{
    public class ProcessoEndereco : ProcessoCadastroBase<Endereco, RepositorioEndereco>
    {
        public BuscarEnderecoQuery InserirEndereco(Endereco endereco)
        {
            new RepositorioEndereco().InserirEndereco(endereco);
            return null;
        }
    }
}
