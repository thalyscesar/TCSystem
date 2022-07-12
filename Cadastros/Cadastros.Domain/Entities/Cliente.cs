using Cadastros.Domain.Enuns;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cadastros.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(Int64 id, string? nome, TipoClinte tipoClinte, string? numeroDocumento)
        {
            Id = id;
            Nome = nome;
            TipoClinte = tipoClinte;
            NumeroDocumento = numeroDocumento;
        }

        public Int64 Id { get; private set; }
        public string? Nome { get; private set; }
        public TipoClinte TipoClinte { get; private set; }
        public string? NumeroDocumento { get; private set; }
    }
}
