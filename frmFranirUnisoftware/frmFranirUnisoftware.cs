using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmFranirUnisoftware
{
    public partial class frmFranirUnisoftware : Form
    {
        public frmFranirUnisoftware()
        {
            InitializeComponent(); 
        }

        #region frmLoad
        private void frmFranirUnisoftware_Load(object sender, EventArgs e)
        {
            var form = new frmVerificaTransacao.frmVerificaTransacao();
            AddFrmPnl(form);
        }
        #endregion

        #region Botões

        #region btnNovaTransacao
        private void btnNovoTransacao_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroTransacao.frmCadastroTransacao();
            foreach (Control controle in pnlConteudo.Controls)
            {
                if (controle.ToString() != form.ToString())
                    AddFrmPnl(form);
            }
        }
        #endregion

        #region btnVerificaTransacao
        private void btnVerificaTransacao_Click(object sender, EventArgs e)
        {
            var form = new frmVerificaTransacao.frmVerificaTransacao();
            foreach (Control controle in pnlConteudo.Controls)
            {
                if (controle.ToString()!=form.ToString())
                    AddFrmPnl(form);
            }
        }
        #endregion

        #region btnFechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region btnMinimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #endregion

        #region Métodos
        private void AddFrmPnl(Form form)
        {
                    pnlConteudo.Controls.Clear();
                    pnlConteudo.Controls.Add(form);
                    form.Dock = DockStyle.Fill;
                    form.Location = Point.Empty;
                    form.Show();
        }
        #endregion


    }
}
