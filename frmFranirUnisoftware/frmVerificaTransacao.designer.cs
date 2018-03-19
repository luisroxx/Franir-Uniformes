namespace frmVerificaTransacao
{
    partial class frmVerificaTransacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.dtgTransacoes = new System.Windows.Forms.DataGridView();
            this.clmNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInformacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.lblVerificarPor = new System.Windows.Forms.Label();
            this.lblPeriodoOuMes = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblTotalPeríodo = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.rdbCadastroDia = new System.Windows.Forms.RadioButton();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnExcluirTransacao = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransacoes)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(29, 86);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(311, 28);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // dtgTransacoes
            // 
            this.dtgTransacoes.AllowUserToAddRows = false;
            this.dtgTransacoes.AllowUserToDeleteRows = false;
            this.dtgTransacoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.NullValue = null;
            this.dtgTransacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTransacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgTransacoes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTransacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgTransacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNomeCliente,
            this.clmTipoTransacao,
            this.clmDataTransacao,
            this.clmParcelas,
            this.clmValor,
            this.clmInformacoes,
            this.clmCodigoTransacao});
            this.dtgTransacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTransacoes.Location = new System.Drawing.Point(0, 124);
            this.dtgTransacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgTransacoes.MultiSelect = false;
            this.dtgTransacoes.Name = "dtgTransacoes";
            this.dtgTransacoes.ReadOnly = true;
            this.dtgTransacoes.RowHeadersVisible = false;
            this.dtgTransacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTransacoes.Size = new System.Drawing.Size(1725, 391);
            this.dtgTransacoes.TabIndex = 1;
            // 
            // clmNomeCliente
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmNomeCliente.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmNomeCliente.HeaderText = "Nome do cliente";
            this.clmNomeCliente.MinimumWidth = 100;
            this.clmNomeCliente.Name = "clmNomeCliente";
            this.clmNomeCliente.ReadOnly = true;
            this.clmNomeCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNomeCliente.Width = 216;
            // 
            // clmTipoTransacao
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTipoTransacao.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmTipoTransacao.HeaderText = "Tipo da transacao";
            this.clmTipoTransacao.MinimumWidth = 100;
            this.clmTipoTransacao.Name = "clmTipoTransacao";
            this.clmTipoTransacao.ReadOnly = true;
            this.clmTipoTransacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmTipoTransacao.Width = 215;
            // 
            // clmDataTransacao
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "g";
            dataGridViewCellStyle13.NullValue = null;
            this.clmDataTransacao.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmDataTransacao.HeaderText = "Data da parcela";
            this.clmDataTransacao.MinimumWidth = 100;
            this.clmDataTransacao.Name = "clmDataTransacao";
            this.clmDataTransacao.ReadOnly = true;
            this.clmDataTransacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmDataTransacao.Width = 216;
            // 
            // clmParcelas
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmParcelas.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmParcelas.HeaderText = "Parcelas";
            this.clmParcelas.MinimumWidth = 100;
            this.clmParcelas.Name = "clmParcelas";
            this.clmParcelas.ReadOnly = true;
            this.clmParcelas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmParcelas.Width = 216;
            // 
            // clmValor
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = null;
            this.clmValor.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmValor.HeaderText = "Valor";
            this.clmValor.MinimumWidth = 90;
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            this.clmValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmValor.Width = 215;
            // 
            // clmInformacoes
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmInformacoes.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmInformacoes.HeaderText = "Informações adicionais";
            this.clmInformacoes.MinimumWidth = 130;
            this.clmInformacoes.Name = "clmInformacoes";
            this.clmInformacoes.ReadOnly = true;
            this.clmInformacoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmInformacoes.Width = 216;
            // 
            // clmCodigoTransacao
            // 
            this.clmCodigoTransacao.HeaderText = "CodigoTransacao";
            this.clmCodigoTransacao.MinimumWidth = 97;
            this.clmCodigoTransacao.Name = "clmCodigoTransacao";
            this.clmCodigoTransacao.ReadOnly = true;
            this.clmCodigoTransacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCodigoTransacao.Visible = false;
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(188, 16);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(78, 21);
            this.rdbPeriodo.TabIndex = 0;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            this.rdbPeriodo.CheckedChanged += new System.EventHandler(this.rdbPeriodo_CheckedChanged);
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(280, 16);
            this.rdbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(55, 21);
            this.rdbMes.TabIndex = 1;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Mês";
            this.rdbMes.UseVisualStyleBackColor = true;
            this.rdbMes.CheckedChanged += new System.EventHandler(this.rdbMes_CheckedChanged);
            // 
            // lblVerificarPor
            // 
            this.lblVerificarPor.AutoSize = true;
            this.lblVerificarPor.Location = new System.Drawing.Point(25, 16);
            this.lblVerificarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarPor.Name = "lblVerificarPor";
            this.lblVerificarPor.Size = new System.Drawing.Size(163, 17);
            this.lblVerificarPor.TabIndex = 4;
            this.lblVerificarPor.Text = "Verificar transações por:";
            // 
            // lblPeriodoOuMes
            // 
            this.lblPeriodoOuMes.AutoSize = true;
            this.lblPeriodoOuMes.Location = new System.Drawing.Point(25, 54);
            this.lblPeriodoOuMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoOuMes.Name = "lblPeriodoOuMes";
            this.lblPeriodoOuMes.Size = new System.Drawing.Size(26, 17);
            this.lblPeriodoOuMes.TabIndex = 5;
            this.lblPeriodoOuMes.Text = "Dê";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(65, 53);
            this.dtpDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(125, 22);
            this.dtpDe.TabIndex = 2;
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(248, 54);
            this.dtpAte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(125, 22);
            this.dtpAte.TabIndex = 3;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(145, 53);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(52, 24);
            this.cmbMes.TabIndex = 2;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(208, 54);
            this.lblAte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(33, 17);
            this.lblAte.TabIndex = 9;
            this.lblAte.Text = "Até:";
            // 
            // lblTotalPeríodo
            // 
            this.lblTotalPeríodo.AutoSize = true;
            this.lblTotalPeríodo.Location = new System.Drawing.Point(16, 16);
            this.lblTotalPeríodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPeríodo.Name = "lblTotalPeríodo";
            this.lblTotalPeríodo.Size = new System.Drawing.Size(116, 17);
            this.lblTotalPeríodo.TabIndex = 11;
            this.lblTotalPeríodo.Text = "Total do período:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(156, 16);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 17);
            this.lblValorTotal.TabIndex = 12;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.rdbCadastroDia);
            this.pnlSuperior.Controls.Add(this.lblVerificarPor);
            this.pnlSuperior.Controls.Add(this.btnVerificar);
            this.pnlSuperior.Controls.Add(this.cmbAno);
            this.pnlSuperior.Controls.Add(this.rdbPeriodo);
            this.pnlSuperior.Controls.Add(this.lblAte);
            this.pnlSuperior.Controls.Add(this.rdbMes);
            this.pnlSuperior.Controls.Add(this.cmbMes);
            this.pnlSuperior.Controls.Add(this.lblPeriodoOuMes);
            this.pnlSuperior.Controls.Add(this.dtpAte);
            this.pnlSuperior.Controls.Add(this.dtpDe);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1725, 124);
            this.pnlSuperior.TabIndex = 13;
            // 
            // rdbCadastroDia
            // 
            this.rdbCadastroDia.AutoSize = true;
            this.rdbCadastroDia.Location = new System.Drawing.Point(348, 16);
            this.rdbCadastroDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCadastroDia.Name = "rdbCadastroDia";
            this.rdbCadastroDia.Size = new System.Drawing.Size(140, 21);
            this.rdbCadastroDia.TabIndex = 10;
            this.rdbCadastroDia.TabStop = true;
            this.rdbCadastroDia.Text = "Movimento do dia";
            this.rdbCadastroDia.UseVisualStyleBackColor = true;
            this.rdbCadastroDia.CheckedChanged += new System.EventHandler(this.rdbCadastroDia_CheckedChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(332, 53);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(65, 24);
            this.cmbAno.TabIndex = 3;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.White;
            this.pnlInferior.Controls.Add(this.btnExcluirTransacao);
            this.pnlInferior.Controls.Add(this.lblTotalPeríodo);
            this.pnlInferior.Controls.Add(this.lblValorTotal);
            this.pnlInferior.Controls.Add(this.btnExportarExcel);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 515);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1725, 44);
            this.pnlInferior.TabIndex = 14;
            // 
            // btnExcluirTransacao
            // 
            this.btnExcluirTransacao.Enabled = false;
            this.btnExcluirTransacao.Image = global::frmFranirUnisoftware.Properties.Resources._1391496456_trash;
            this.btnExcluirTransacao.Location = new System.Drawing.Point(366, 6);
            this.btnExcluirTransacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirTransacao.Name = "btnExcluirTransacao";
            this.btnExcluirTransacao.Size = new System.Drawing.Size(40, 37);
            this.btnExcluirTransacao.TabIndex = 14;
            this.btnExcluirTransacao.UseVisualStyleBackColor = true;
            this.btnExcluirTransacao.Click += new System.EventHandler(this.btnExcluirTransacao_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Enabled = false;
            this.btnExportarExcel.Image = global::frmFranirUnisoftware.Properties.Resources._1391496253_excel;
            this.btnExportarExcel.Location = new System.Drawing.Point(318, 6);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(40, 37);
            this.btnExportarExcel.TabIndex = 13;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmVerificaTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1725, 559);
            this.ControlBox = false;
            this.Controls.Add(this.dtgTransacoes);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVerificaTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVerificaTransacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransacoes)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DataGridView dtgTransacoes;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.Label lblVerificarPor;
        private System.Windows.Forms.Label lblPeriodoOuMes;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblTotalPeríodo;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Button btnExcluirTransacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoTransacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataTransacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInformacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoTransacao;
        private System.Windows.Forms.RadioButton rdbCadastroDia;
    }
}

