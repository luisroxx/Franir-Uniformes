namespace frmFranirUnisoftware
{
    partial class frmFranirUnisoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFranirUnisoftware));
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVerificaTransacao = new System.Windows.Forms.Button();
            this.btnNovoTransacao = new System.Windows.Forms.Button();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 131);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(1300, 598);
            this.pnlConteudo.TabIndex = 7;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(13)))));
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenu.Controls.Add(this.btnMinimizar);
            this.pnlMenu.Controls.Add(this.btnFechar);
            this.pnlMenu.Controls.Add(this.btnVerificaTransacao);
            this.pnlMenu.Controls.Add(this.btnNovoTransacao);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1300, 131);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::frmFranirUnisoftware.Properties.Resources._1391512373_152;
            this.btnMinimizar.Location = new System.Drawing.Point(1214, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 21);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1259, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 21);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVerificaTransacao
            // 
            this.btnVerificaTransacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerificaTransacao.BackgroundImage")));
            this.btnVerificaTransacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerificaTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificaTransacao.Image = global::frmFranirUnisoftware.Properties.Resources._1391516290_search_b;
            this.btnVerificaTransacao.Location = new System.Drawing.Point(445, 8);
            this.btnVerificaTransacao.Name = "btnVerificaTransacao";
            this.btnVerificaTransacao.Size = new System.Drawing.Size(144, 67);
            this.btnVerificaTransacao.TabIndex = 5;
            this.btnVerificaTransacao.UseVisualStyleBackColor = true;
            this.btnVerificaTransacao.Click += new System.EventHandler(this.btnVerificaTransacao_Click);
            // 
            // btnNovoTransacao
            // 
            this.btnNovoTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoTransacao.Image = global::frmFranirUnisoftware.Properties.Resources._1391497129_icon_person_add;
            this.btnNovoTransacao.Location = new System.Drawing.Point(295, 8);
            this.btnNovoTransacao.Name = "btnNovoTransacao";
            this.btnNovoTransacao.Size = new System.Drawing.Size(144, 67);
            this.btnNovoTransacao.TabIndex = 4;
            this.btnNovoTransacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoTransacao.UseVisualStyleBackColor = true;
            this.btnNovoTransacao.Click += new System.EventHandler(this.btnNovoTransacao_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(13)))));
            this.pnlRodape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRodape.BackgroundImage")));
            this.pnlRodape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 729);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1300, 21);
            this.pnlRodape.TabIndex = 8;
            // 
            // frmFranirUnisoftware
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.ControlBox = false;
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "frmFranirUnisoftware";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFranirUnisoftware_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoTransacao;
        private System.Windows.Forms.Button btnVerificaTransacao;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
    }
}

