using Cadastros.Processo.Processo;

namespace Cadastros.Control.Commands.Banco
{
    public class AtualizarBanco
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public bool PodeAtualizar()
        {
            var bancoObtido = new ProcessoBanco().BuscarBanco(this.Nome);

            if (bancoObtido == null) return true;

            return bancoObtido.Id == this.Id;
        }
    }
}
