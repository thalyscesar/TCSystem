using Cadastros.Control.Commands.Banco;
using Cadastros.Control.Controlador;
using Cadastros.Processo.Queries;

namespace Cadastros.Forms.Banco
{
    public partial class frmBanco : Form
    {
        public frmBanco() : this(null)
        {

        }

        public frmBanco(BuscarBancoQuery buscarBancoQuery)
        {
            InitializeComponent();

            this.buscarBancoQuery = buscarBancoQuery;

            if (buscarBancoQuery != null)
            {
                this.lblTitulo.Text = "Atualizar Banco";
                this.txtNomeBanco.Text = this.buscarBancoQuery.Nome;
            }

            txtNomeBanco.TabIndex = 0;
            var x = txtNomeBanco.Focus();
        }
        private BuscarBancoQuery buscarBancoQuery;

        private BancoControl control = new BancoControl();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!this.PodeSalvar()) return;

            AdicionarBanco adicionarBanco = CriarAdicionarBanco();

            var modoFormulario = "adicionar";
            if (this.EParaAtualizar())
            {
                modoFormulario = "atualizar";
                adicionarBanco.Id = buscarBancoQuery.Id;
            }

            var confirmacao = MessageBox.Show($"Tem certeza que quer {modoFormulario} o banco {adicionarBanco.Nome}?", this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                var salvou = this.EParaAtualizar() ? control.Atualizar(new AtualizarBanco() { Id = (int)adicionarBanco.Id, Nome = adicionarBanco.Nome }) : control.Adicionar(adicionarBanco);

                if (!salvou)
                {
                    MessageBox.Show("Erro ao realizar operação");
                    return;
                }

                MessageBox.Show("Operacao realizada com sucesso");
                this.Close();
                txtNomeBanco.Text = "";
            }
        }

        private AdicionarBanco CriarAdicionarBanco()
        {
            return new AdicionarBanco { Nome = txtNomeBanco.Text };
        }

        private bool EParaAtualizar()
        {
            return this.buscarBancoQuery != null;
        }

        private bool PodeSalvar()
        {
            var resultado = control.ObterResultadoValidacao(CriarAdicionarBanco());

            if (resultado.IsValid) return true;

            var mensagens = string.Join('\n', resultado.Errors.Select(s => s.ErrorMessage));

            MessageBox.Show(mensagens);

            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
