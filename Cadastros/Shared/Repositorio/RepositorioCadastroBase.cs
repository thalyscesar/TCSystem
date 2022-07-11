using DapperExtensions.Mapper;
using Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositorio
{
    public class RepositorioCadastroBase<TEntity,TMap> : 
        IRepositorioCadastro<TEntity> where TEntity : Entity
        where TMap : ClassMapper<TEntity> 
    {
        public RepositorioCadastroBase()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(TMap).Assembly });
        }

        public bool Atualizar(TEntity entity)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Atualizar(entity);
        }

        public bool Excluir(TEntity entity)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Excluir(entity);
        }

        public bool Inserir(TEntity entity)
        {
           return DBHelper<TEntity>.InstanciaNpgsql.Inserir(entity);
        }

        public TEntity BuscarPorId(long id)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Get(id);

        }

        public List<TEntity> BuscarTodos()
        {
            return DBHelper<TEntity>.InstanciaNpgsql.GetAll();

        }

        public void Commit()
        {
            DBHelper<TEntity>.InstanciaNpgsql.CommitTransaction();
        }

        public void Roolback()
        {
            DBHelper<TEntity>.InstanciaNpgsql.RollbackTransaction();
        }

        public void IniciarTransacao()
        {
            DBHelper<TEntity>.InstanciaNpgsql.BeginTransaction();
        }
    }
}
