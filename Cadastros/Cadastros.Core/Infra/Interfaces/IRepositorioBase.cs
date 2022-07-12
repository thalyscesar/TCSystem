
using DapperExtensions.Mapper;

namespace Cadastros.Core.Infra.Interfaces
{
    public interface IRepositorioBase<TEntity>
        where TEntity : class
    {
        bool Atualizar(TEntity entity);

        bool Excluir(TEntity entity);

        Int64 Inserir(TEntity entity);

        TEntity BuscarPorId(long id);

        List<TEntity> BuscarTodos();

        void Commit();

        void Roolback();

        void IniciarTransacao();
    }
}
