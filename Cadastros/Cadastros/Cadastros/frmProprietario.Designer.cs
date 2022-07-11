namespace Cadastros.Forms
{
    partial class frmProprietario
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProprietario = new System.Windows.Forms.TabPage();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.sltBanco = new System.Windows.Forms.ComboBox();
            this.txtCodigoAgencia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblCodigoAgencia = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TabPage();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbProprietario.SuspendLayout();
            this.tbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(614, 329);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(288, 29);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(135, 15);
            this.lblProprietario.TabIndex = 3;
            this.lblProprietario.Text = "Cadastro de proprietário";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(524, 329);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCampos.TabIndex = 14;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProprietario);
            this.tabControl1.Controls.Add(this.tbEndereco);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 276);
            this.tabControl1.TabIndex = 15;
            // 
            // tbProprietario
            // 
            this.tbProprietario.Controls.Add(this.txtNumeroConta);
            this.tbProprietario.Controls.Add(this.lblNumeroConta);
            this.tbProprietario.Controls.Add(this.lblBanco);
            this.tbProprietario.Controls.Add(this.sltBanco);
            this.tbProprietario.Controls.Add(this.txtCodigoAgencia);
            this.tbProprietario.Controls.Add(this.txtEmail);
            this.tbProprietario.Controls.Add(this.txtCpf);
            this.tbProprietario.Controls.Add(this.txtRg);
            this.tbProprietario.Controls.Add(this.txtObservacao);
            this.tbProprietario.Controls.Add(this.txtCelular);
            this.tbProprietario.Controls.Add(this.txtTelefone);
            this.tbProprietario.Controls.Add(this.lblCodigoAgencia);
            this.tbProprietario.Controls.Add(this.lblObservacao);
            this.tbProprietario.Controls.Add(this.lblRg);
            this.tbProprietario.Controls.Add(this.lblCpf);
            this.tbProprietario.Controls.Add(this.lblEmail);
            this.tbProprietario.Controls.Add(this.lblCelular);
            this.tbProprietario.Controls.Add(this.lblTelefone);
            this.tbProprietario.Controls.Add(this.txtNome);
            this.tbProprietario.Controls.Add(this.label1);
            this.tbProprietario.Location = new System.Drawing.Point(4, 24);
            this.tbProprietario.Name = "tbProprietario";
            this.tbProprietario.Padding = new System.Windows.Forms.Padding(3);
            this.tbProprietario.Size = new System.Drawing.Size(647, 248);
            this.tbProprietario.TabIndex = 0;
            this.tbProprietario.Text = "Informações proprietario";
            this.tbProprietario.UseVisualStyleBackColor = true;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(536, 52);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroConta.TabIndex = 50;
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(427, 55);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(103, 15);
            this.lblNumeroConta.TabIndex = 49;
            this.lblNumeroConta.Text = "Número da conta:";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(4, 55);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(43, 15);
            this.lblBanco.TabIndex = 48;
            this.lblBanco.Text = "Banco:";
            // 
            // sltBanco
            // 
            this.sltBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltBanco.FormattingEnabled = true;
            this.sltBanco.Location = new System.Drawing.Point(74, 52);
            this.sltBanco.Name = "sltBanco";
            this.sltBanco.Size = new System.Drawing.Size(100, 23);
            this.sltBanco.TabIndex = 47;
            // 
            // txtCodigoAgencia
            // 
            this.txtCodigoAgencia.Location = new System.Drawing.Point(307, 52);
            this.txtCodigoAgencia.Name = "txtCodigoAgencia";
            this.txtCodigoAgencia.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoAgencia.TabIndex = 46;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(536, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 44;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(307, 17);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 43;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(536, 17);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 23);
            this.txtRg.TabIndex = 42;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(74, 126);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(100, 23);
            this.txtObservacao.TabIndex = 41;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(307, 90);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 23);
            this.txtCelular.TabIndex = 38;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 87);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 37;
            // 
            // lblCodigoAgencia
            // 
            this.lblCodigoAgencia.AutoSize = true;
            this.lblCodigoAgencia.Location = new System.Drawing.Point(195, 55);
            this.lblCodigoAgencia.Name = "lblCodigoAgencia";
            this.lblCodigoAgencia.Size = new System.Drawing.Size(109, 15);
            this.lblCodigoAgencia.TabIndex = 35;
            this.lblCodigoAgencia.Text = "Código da agência:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(2, 129);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(72, 15);
            this.lblObservacao.TabIndex = 32;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(427, 23);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(25, 15);
            this.lblRg.TabIndex = 31;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(195, 20);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 30;
            this.lblCpf.Text = "CPF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(427, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(195, 93);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 28;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(2, 90);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 15);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Controls.Add(this.txtEstado);
            this.tbEndereco.Controls.Add(this.txtCidade);
            this.tbEndereco.Controls.Add(this.txtBairro);
            this.tbEndereco.Controls.Add(this.txtLogradouro);
            this.tbEndereco.Controls.Add(this.txtNumero);
            this.tbEndereco.Controls.Add(this.txtCep);
            this.tbEndereco.Controls.Add(this.lblCep);
            this.tbEndereco.Controls.Add(this.lblEstado);
            this.tbEndereco.Controls.Add(this.lblCidade);
            this.tbEndereco.Controls.Add(this.lblBairro);
            this.tbEndereco.Controls.Add(this.lblLogradouro);
            this.tbEndereco.Controls.Add(this.lblNumero);
            this.tbEndereco.Controls.Add(this.lblTitulo);
            this.tbEndereco.Location = new System.Drawing.Point(4, 24);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tbEndereco.Size = new System.Drawing.Size(647, 248);
            this.tbEndereco.TabIndex = 1;
            this.tbEndereco.Text = "Endereço";
            this.tbEndereco.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(269, 57);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 23);
            this.txtEstado.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(483, 57);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 23);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(61, 96);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 23);
            this.txtBairro.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(269, 96);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(100, 23);
            this.txtLogradouro.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(483, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(61, 57);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 23);
            this.txtCep.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(6, 63);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 15);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(208, 63);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(423, 63);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 99);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 15);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(191, 99);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(72, 15);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(423, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(210, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro do endereço";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(431, 329);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 364);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmProprietario";
            this.Text = "frmProprietario";
            this.tabControl1.ResumeLayout(false);
            this.tbProprietario.ResumeLayout(false);
            this.tbProprietario.PerformLayout();
            this.tbEndereco.ResumeLayout(false);
            this.tbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSalvar;
        private Label lblProprietario;
        private Button btnLimparCampos;
        private TabControl tabControl1;
        private TabPage tbProprietario;
        private TextBox txtNumeroConta;
        private Label lblNumeroConta;
        private Label lblBanco;
        private ComboBox sltBanco;
        private TextBox txtCodigoAgencia;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtRg;
        private TextBox txtObservacao;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private Label lblCodigoAgencia;
        private Label lblObservacao;
        private Label lblRg;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblCelular;
        private Label lblTelefone;
        private TextBox txtNome;
        private Label label1;
        private TabPage tbEndereco;
        private Label lblTitulo;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtCep;
        private Label lblCep;
        private Label lblEstado;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblLogradouro;
        private Label lblNumero;
        private Button btnFechar;
    }
}