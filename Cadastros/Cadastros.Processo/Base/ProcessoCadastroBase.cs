using Cadastros.Dominio.Entidades;
using Shared;
using Shared.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Processo.Base
{
    public abstract class ProcessoCadastroBase<TEntity, TRepositorio>
        where TEntity : Entity
        where TRepositorio : IRepositorioCadastro<TEntity>, new()
    {

        public ProcessoCadastroBase()
        {
            this.Repositorio = new TRepositorio();
        }

        protected TRepositorio Repositorio { get; private set; }

        public virtual bool Atualizar(TEntity entity)
        {
            return this.Repositorio.Atualizar(entity);
        }

        public virtual bool Excluir(TEntity entity)
        {
            return this.Repositorio.Excluir(entity);
        }

        public virtual bool Inserir(TEntity entity)
        {
           return this.Repositorio.Inserir(entity);
        }

        public TEntity BuscarPorId(long id)
        {
            return this.Repositorio.BuscarPorId(id);
        }
    }
}
