using Cadastros.Control.Commands;
using Cadastros.Control.Controlador;
using Cadastros.Forms.Banco;
using Cadastros.Processo.Processo;
using Cadastros.Processo.Queries;
using System.Data;

namespace Cadastros.Forms
{
    public partial class frmProprietario : Form
    {
        public frmProprietario()
        {
            InitializeComponent();
            sltBanco.ValueMember = "Id";
            sltBanco.DisplayMember = "Nome";
            sltBanco.DataSource = proprietarioControl.ObterBancos();
        }

        private ProprietarioControl proprietarioControl = new ProprietarioControl();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var proprietario = this.CriarAdicionarProprietario();

            if (this.PodeSalvarProprietario(proprietario))
            {
                var salvou = proprietarioControl.Adicionar(proprietario);

                if (salvou)
                {
                    MessageBox.Show("Dados salvo com sucesso");
                    return;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public AdicionarProprietario CriarAdicionarProprietario()
        {


            return new AdicionarProprietario
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Email = txtEmail.Text,
                CPF = txtCpf.Text,
                RG = txtRg.Text,
                Observacao = txtObservacao.Text,
                IdBanco = (int)((BuscarBancoQuery)sltBanco.SelectedItem).Id,
                CodigoAgencia = txtCodigoAgencia.Text,
                NumeroConta = txtNumeroConta.Text,
                CEP = txtCep.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text
            };
        }

        private bool PodeSalvarProprietario(AdicionarProprietario adicionarProprietario)
        {
            var resultado = proprietarioControl.ObterResultadoValidacao(adicionarProprietario);

            if (resultado.IsValid) return true;

            var mensagens = string.Join('\n', resultado.Errors.Select(s => s.ErrorMessage));

            MessageBox.Show(mensagens);

            return false;
        }
    }
}
