using Cadastros.Dominio.Entidades;
using Cadastros.Processo.Mappers;
using Cadastros.Processo.Queries;
using Shared.Data;
using Shared.Repositorio;
using System.Globalization;
using System.Text;

namespace Cadastros.Processo.Repositorio
{

    public class RepositorioBanco : RepositorioCadastroBase<Banco, BancoMap>
    {
        public bool BancoExiste(string? nome)
        {
            string querySelect = String.Format("select count(*) from cadastro.banco where unaccent(UPPER(TRIM(nome))) = '{0}'", this.RemoverAcentos(nome.ToUpper()));
            var resultado = DBHelper<Banco>.InstanciaNpgsql.Get(querySelect);

            return resultado > 0;
        }

        public List<BuscarBancoQuery> BuscarBancos(string inicial)
        {
            string querySelect = String.Format("select id, nome from cadastro.banco where unaccent(UPPER(TRIM(nome))) like '{0}%'", this.RemoverAcentos(inicial.ToUpper()));
            return DBHelper<Banco>.InstanciaNpgsql.GetQuery(querySelect).Select(b => new BuscarBancoQuery() { Id = b.Id, Nome = b.Nome }).ToList();
        }

        public BuscarBancoQuery BuscarBanco(string? nome)
        {
            string querySelect = String.Format("select id, nome from cadastro.banco where unaccent(UPPER(TRIM(nome))) = '{0}';", this.RemoverAcentos(nome.ToUpper()));
            var bancos = DBHelper<Banco>.InstanciaNpgsql.GetQuery(querySelect);

            var banco = bancos.FirstOrDefault();

            if (banco != null) return new BuscarBancoQuery() { Id = banco.Id, Nome = banco.Nome };

            return null;
        }



        public string RemoverAcentos(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                {
                    sbReturn.Append(letra);
                }
            }
            return sbReturn.ToString();
        }
    }
}
