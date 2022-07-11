using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Base;
using Cadastros.Processo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Processo
{
    public class ProcessoProprietario : ProcessoCadastroBase<Proprietario, RepositorioProprietario>
    {
        public bool ProprietarioExiste(string cpf)
        {
            return Repositorio.ProprietarioExiste(cpf);
        }
    }
}
