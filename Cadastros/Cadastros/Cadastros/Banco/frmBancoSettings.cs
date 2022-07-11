using Cadastros.Control.Controlador;
using Cadastros.Processo.Queries;

namespace Cadastros.Forms.Banco
{
    public partial class frmBancoSettings : Form
    {
        public frmBancoSettings()
        {
            InitializeComponent();
            this.CarregarDataGrid("");
        }

        private BancoControl bancoControl = new BancoControl();

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (bsBancos.Current == null) return;

            frmBanco frmBanco = new frmBanco((BuscarBancoQuery)bsBancos.Current);
            frmBanco.ShowDialog(this);

            this.CarregarDataGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!this.BancoEstaSelecionado()) MessageBox.Show("Selecione um banco");

            var confirmacao = MessageBox.Show($"Tem certeza que quer excluir o banco {((BuscarBancoQuery)bsBancos.Current).Nome}?", this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                var apagou = bancoControl.Excluir((BuscarBancoQuery)bsBancos.Current);

                if (!apagou) 
                { 
                    MessageBox.Show("Erro ao excluir");
                    return;
                }

                MessageBox.Show("Excluido com sucesso");

                this.CarregarDataGrid("");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (bsBancos.Current != null) MessageBox.Show("Selecione um banco");
            frmBanco frmBanco = new frmBanco((BuscarBancoQuery)bsBancos.Current);
            frmBanco.ShowDialog(this);

            this.CarregarDataGrid("");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmBanco frmBanco = new frmBanco();
            frmBanco.ShowDialog(this);

            this.CarregarDataGrid("");
        }

        private bool BancoEstaSelecionado()
        {
            return dgBancos.SelectedRows != null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            this.CarregarDataGrid(txtBuscar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<BuscarBancoQuery> CarregarDataGrid(string inicial)
        {
            List<BuscarBancoQuery> bancos = new List<BuscarBancoQuery>();

            foreach (var banco in bancoControl.BuscarBancoQueries(inicial))
            {
                bancos.Add(new BuscarBancoQuery() { Id = banco.Id, Nome = banco.Nome });
            }

            bsBancos.DataSource = bancos;
            dgBancos.DataSource = bsBancos;
            dgBancos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBancos.ClearSelection();
            dgBancos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return bancos;
        }
    }
}
