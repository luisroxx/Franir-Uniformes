namespace frmCadastroTransacao
{
    partial class frmCadastroTransacao
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblDataDaTransacao = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbParcelas = new System.Windows.Forms.ComboBox();
            this.dtpDataTransacao = new System.Windows.Forms.DateTimePicker();
            this.lblNovaTransacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(23, 430);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(437, 60);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(150, 130);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(152, 21);
            this.cmbTipoPagamento.TabIndex = 1;
            this.cmbTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPagamento_SelectedIndexChanged);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(20, 100);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(150, 100);
            this.txtNomeCliente.MaxLength = 80;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(362, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(20, 130);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(99, 13);
            this.lblTipoPagamento.TabIndex = 4;
            this.lblTipoPagamento.Text = "Tipo do pagamento";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(20, 160);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(20, 190);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 6;
            this.lblBanco.Text = "Banco";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(20, 220);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 7;
            this.lblAgencia.Text = "Agencia";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(20, 250);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 8;
            this.lblConta.Text = "Conta";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 280);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(20, 340);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(20, 370);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(48, 13);
            this.lblParcelas.TabIndex = 11;
            this.lblParcelas.Text = "Parcelas";
            // 
            // lblDataDaTransacao
            // 
            this.lblDataDaTransacao.AutoSize = true;
            this.lblDataDaTransacao.Location = new System.Drawing.Point(20, 310);
            this.lblDataDaTransacao.Name = "lblDataDaTransacao";
            this.lblDataDaTransacao.Size = new System.Drawing.Size(95, 13);
            this.lblDataDaTransacao.TabIndex = 13;
            this.lblDataDaTransacao.Text = "Data da transação";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(150, 160);
            this.txtEmpresa.MaxLength = 20;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(152, 20);
            this.txtEmpresa.TabIndex = 2;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(150, 190);
            this.txtBanco.MaxLength = 3;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(65, 20);
            this.txtBanco.TabIndex = 3;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QualquerNumero_KeyPress);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(150, 220);
            this.txtAgencia.MaxLength = 4;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(65, 20);
            this.txtAgencia.TabIndex = 4;
            this.txtAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QualquerNumero_KeyPress);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(150, 250);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(65, 20);
            this.txtConta.TabIndex = 5;
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QualquerNumero_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(150, 280);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(152, 20);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QualquerNumero_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(150, 340);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(65, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // cmbParcelas
            // 
            this.cmbParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelas.FormattingEnabled = true;
            this.cmbParcelas.Location = new System.Drawing.Point(150, 370);
            this.cmbParcelas.Name = "cmbParcelas";
            this.cmbParcelas.Size = new System.Drawing.Size(65, 21);
            this.cmbParcelas.TabIndex = 9;
            // 
            // dtpDataTransacao
            // 
            this.dtpDataTransacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTransacao.Location = new System.Drawing.Point(150, 310);
            this.dtpDataTransacao.Name = "dtpDataTransacao";
            this.dtpDataTransacao.Size = new System.Drawing.Size(152, 20);
            this.dtpDataTransacao.TabIndex = 7;
            // 
            // lblNovaTransacao
            // 
            this.lblNovaTransacao.AutoSize = true;
            this.lblNovaTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaTransacao.Location = new System.Drawing.Point(144, 54);
            this.lblNovaTransacao.Name = "lblNovaTransacao";
            this.lblNovaTransacao.Size = new System.Drawing.Size(214, 31);
            this.lblNovaTransacao.TabIndex = 14;
            this.lblNovaTransacao.Text = "Nova Transação";
            // 
            // frmCadastroTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.lblNovaTransacao);
            this.Controls.Add(this.dtpDataTransacao);
            this.Controls.Add(this.cmbParcelas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblDataDaTransacao);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.cmbTipoPagamento);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transação";
            this.Load += new System.EventHandler(this.frmCadastroTransacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroTransacao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblDataDaTransacao;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbParcelas;
        private System.Windows.Forms.DateTimePicker dtpDataTransacao;
        private System.Windows.Forms.Label lblNovaTransacao;
    }
}

