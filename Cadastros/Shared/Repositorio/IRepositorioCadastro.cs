using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositorio
{
    public interface IRepositorioCadastro<T> where T : Entity
    {
         bool Inserir(T entity);
         bool Atualizar(T entity);
         bool Excluir(T entity);
         void Roolback();
         void Commit();
         void IniciarTransacao();
         T BuscarPorId(long id);
    }
}
