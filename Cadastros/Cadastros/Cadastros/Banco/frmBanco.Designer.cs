namespace Cadastros.Forms.Banco
{
    partial class frmBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.bodyConteudo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.fieldNome = new System.Windows.Forms.Label();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.bodyConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // bodyConteudo
            // 
            this.bodyConteudo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bodyConteudo.Controls.Add(this.lblTitulo);
            this.bodyConteudo.Controls.Add(this.btnFechar);
            this.bodyConteudo.Controls.Add(this.btnSalvar);
            this.bodyConteudo.Controls.Add(this.fieldNome);
            this.bodyConteudo.Controls.Add(this.txtNomeBanco);
            this.bodyConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyConteudo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bodyConteudo.Location = new System.Drawing.Point(0, 0);
            this.bodyConteudo.Name = "bodyConteudo";
            this.bodyConteudo.Size = new System.Drawing.Size(508, 186);
            this.bodyConteudo.TabIndex = 0;
            this.bodyConteudo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(93, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro Banco";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(327, 144);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(427, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // fieldNome
            // 
            this.fieldNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldNome.Location = new System.Drawing.Point(86, 88);
            this.fieldNome.Name = "fieldNome";
            this.fieldNome.Size = new System.Drawing.Size(54, 23);
            this.fieldNome.TabIndex = 3;
            this.fieldNome.Text = "Nome:";
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeBanco.Location = new System.Drawing.Point(146, 87);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.PlaceholderText = "ex: Caixa";
            this.txtNomeBanco.Size = new System.Drawing.Size(148, 24);
            this.txtNomeBanco.TabIndex = 4;
            // 
            // frmBanco
            // 
            this.ClientSize = new System.Drawing.Size(508, 186);
            this.Controls.Add(this.bodyConteudo);
            this.Name = "frmBanco";
            this.Text = "Cadastro Banco";
            this.bodyConteudo.ResumeLayout(false);
            this.bodyConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private GroupBox bodyConteudo;
        private Button btnSalvar;
        private Label fieldNome;
        private Button btnFechar;
        private Label lblTitulo;
        private TextBox txtNomeBanco;
    }
}