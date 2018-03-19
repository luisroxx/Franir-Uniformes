using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace frmCadastroTransacao
{
    public partial class frmCadastroTransacao : Form
    {
        public frmCadastroTransacao()
        {
            InitializeComponent();
            TopLevel = false;
        }

        #region Variáveis
        private string connString = "server=localhost;username=root;pwd=root;database=franirunisoftware"; //String de conexão com o banco
        private string Valor=""; //String que séra utilizada na formatação do txtValor (na aba KeyPress)
        #endregion

        #region frmLoad
        private void frmCadastroTransacao_Load(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region OnChange
        private void cmbTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPagamento.SelectedIndex == 0) //Crédito
            {
                ReordenaCartão();
            }
            else
                if (cmbTipoPagamento.SelectedIndex == 1) //Débito
                {
                    ReordenaCartão();
                    lblParcelas.Visible = false;
                    cmbParcelas.Visible = false;
                }
                else //Cheque
                {
                    ReordenaCheque();
                }
        }
        #endregion

        #region KeyPress

        #region Valor
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            string ValorEditado = "";
            bool AndaVirgula = false;
            //Se Número foi digitado adiciona acrescenta número e virgula se necessário
            #region Número Digitado
            if (e.KeyChar > 47 && e.KeyChar < 58) //Verifica se um número foi apertado
            {
                if (Valor.Length != 6)
                {
                    if (Valor.Length > 3) //Realoca Virgula se a quantidade de números for maior que 3
                    {
                        for (int i = 0; i < Valor.Length; i++)
                        {
                            if (AndaVirgula)
                            {
                                ValorEditado = ValorEditado + Valor[i].ToString() + ".";
                                AndaVirgula = false;
                            }
                            else
                                if (Valor[i].ToString() == ".")
                                AndaVirgula = true;
                            else
                                ValorEditado = ValorEditado + Valor[i].ToString();
                        }
                        Valor = ValorEditado + e.KeyChar.ToString();
                    }
                    else
                        if (Valor.Length == 1) // Realocação especial se a quantidade de números for igual a 1
                    {
                        Valor = Valor + "." + e.KeyChar.ToString();
                    }
                    else
                        Valor = Valor + e.KeyChar.ToString(); // Adiciona valor se não tiver nada na txt
                    txtValor.Text = "R$ ";
                    txtValor.AppendText(Valor); // Adiciona o valor ao texto R$
                }
            }
            #endregion
            else // Se Backspace foi apertado deleta número e realoca/deleta virgula se necessário
                #region Número Deletado
                if (e.KeyChar == 8) // Verifica se backspace foi apertada
                {
                    if (Valor != "")
                    {
                        for (int i = 0; i < Valor.Length - 1; i++)
                        {
                            if (Valor.Length > 4) //Realoca a vírgula caso a quantidade de carácteres seja maior que 4
                            {
                                if (AndaVirgula == false)
                                    if (Valor[i + 1].ToString() == ".")
                                    {
                                        ValorEditado = ValorEditado + "." + Valor[i].ToString();
                                        AndaVirgula = true;
                                    }
                                    else
                                        ValorEditado = ValorEditado + Valor[i].ToString();
                                else
                                    if (Valor[i].ToString() != ".")
                                        ValorEditado = ValorEditado + Valor[i].ToString();

                            }
                            else
                                if (Valor.Length == 3) //No caso da quantidade de carácteres serem iguais a 3 ele ignora a virgula
                                {
                                    if (Valor[i].ToString() != ".")
                                        ValorEditado = ValorEditado + Valor[i].ToString();
                                }
                                else
                                    ValorEditado = ValorEditado + Valor[i].ToString();
                        }
                        Valor = ValorEditado;

                        if (Valor == "")
                            txtValor.Text = "";
                        else
                            txtValor.Text = "R$ ";

                        txtValor.AppendText(Valor); // Mostra o novo valor depois de apagado o utimo número
                    }
                }
                #endregion

        }
        #endregion

        #region QualquerNúmeroKeyPress
        private void QualquerNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 57) && e.KeyChar !=8 && e.KeyChar !=32) //Verifica se um número foi apertado
            {
                e.Handled = true;
            }
        }
        #endregion

        #region EnterKeyDown
        private void frmCadastroTransacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
#endregion

        #endregion

        #region BotãoConfirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime DataLimite = Convert.ToDateTime("01/01/2014");

            if (txtNomeCliente.Text.Length == 0) //Verifica se o usuário digito 1 nome
            {
                MessageBox.Show("Digite o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (cmbTipoPagamento.SelectedIndex == 2) //Verifica se o cheque está selecionado
                {
                    #region ValidaçãoDeCheque
                    if (txtEmpresa.Text.Length == 0)
                    {
                        MessageBox.Show("Digite o nome da empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        if (txtBanco.Text.Length == 0)
                        {
                            MessageBox.Show("Digite o número do banco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            if (txtAgencia.Text.Length == 0)
                            {
                                MessageBox.Show("Digite o número da agência", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                if (txtConta.Text.Length == 0)
                                {
                                    MessageBox.Show("Digite o número da conta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (txtNumero.Text.Length == 0)
                                {
                                    MessageBox.Show("Digite o número do cheque", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (Convert.ToDateTime(dtpDataTransacao.Text) < DataLimite)
                                    {
                                        MessageBox.Show("Digite uma data maior que " + DataLimite.ToShortDateString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        if (txtValor.Text.Length == 0)
                                        {
                                            MessageBox.Show("Digite o valor da transação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            CadastraBanco("Cheque");
                                        }
                                }
                    #endregion
                }
                else
                {
                    #region ValidaçãoDeCartão
                    if (txtEmpresa.Text.Length == 0)
                    {
                        MessageBox.Show("Digite o nome da empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        //empresa nrcartao dt transacao valor parcelas
                        if (txtNumero.Text.Length == 0)
                        {
                            MessageBox.Show("Digite o número do cartão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Convert.ToDateTime(dtpDataTransacao.Text) < DataLimite)
                            {
                                MessageBox.Show("Digite uma data maior que " + DataLimite.ToShortDateString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                if (txtValor.Text.Length == 0)
                                {
                                    MessageBox.Show("Digite o valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    CadastraBanco("Cartão");
                                }
                        }
                    #endregion
                }
        }
        #endregion

        #region Métodos

        #region LimpaTela
        private void LimpaTela()
        {
            txtNomeCliente.Clear();
            txtEmpresa.Clear();
            txtBanco.Clear();
            txtAgencia.Clear();
            txtConta.Clear();
            txtNumero.Clear();
            Valor = "";
            txtValor.Clear();

            cmbTipoPagamento.Items.Clear();
            cmbTipoPagamento.Items.Add("Crédito");
            cmbTipoPagamento.Items.Add("Débito");
            cmbTipoPagamento.Items.Add("Cheque");
            cmbTipoPagamento.SelectedIndex = 0;
        }
        #endregion

        #region AddParcelasCombo
        private void AddDiaParcelas()
        {
            for (int i = 1; i < 13; i++)
            {
                cmbParcelas.Items.Add(i);
            }
        }
        #endregion

        #region ReordenaCheque
        private void ReordenaCheque()
        {
            lblEmpresa.Text = "Empresa";
            lblNumero.Location = new Point(20, 280);
            lblDataDaTransacao.Location = new Point(20, 310);
            lblValor.Location = new Point(20, 340);
            lblParcelas.Location = new Point(20, 370);
            lblNumero.Text = "Número do Cheque";
            txtNumero.MaxLength = 6;
            txtNumero.Clear();

            lblBanco.Visible = true;
            lblAgencia.Visible = true;
            lblConta.Visible = true;
            lblParcelas.Visible = true;

            lblNumero.Location = new Point(lblConta.Location.X, lblConta.Location.Y + 35);
            txtNumero.Location = new Point(txtConta.Location.X, txtConta.Location.Y + 35);

            lblDataDaTransacao.Location = new Point(lblNumero.Location.X, lblNumero.Location.Y + 35);
            dtpDataTransacao.Location = new Point(txtNumero.Location.X, txtNumero.Location.Y+35);

            lblValor.Location = new Point(lblDataDaTransacao.Location.X, lblDataDaTransacao.Location.Y + 35);
            txtValor.Location = new Point(dtpDataTransacao.Location.X, dtpDataTransacao.Location.Y +35);

            lblParcelas.Location = new Point(lblValor.Location.X, lblValor.Location.Y + 35);
            cmbParcelas.Location = new Point(txtValor.Location.X, txtValor.Location.Y + 35);

            txtBanco.Visible = true;
            txtAgencia.Visible = true;
            txtConta.Visible = true;
            cmbParcelas.Visible = true;

            cmbParcelas.Items.Clear();
            cmbParcelas.Items.Add("À vista");
            AddDiaParcelas();
            cmbParcelas.SelectedIndex = 0;
        }
        #endregion

        #region ReordenaCartão
        private void ReordenaCartão()
        {
            lblBanco.Visible = false;
            lblAgencia.Visible = false;
            lblConta.Visible = false;
            txtBanco.Visible = false;
            txtAgencia.Visible = false;
            txtConta.Visible = false;

            lblParcelas.Visible = true;
            cmbParcelas.Visible = true;

            lblEmpresa.Text = "Bandeira";
            lblNumero.Location = lblBanco.Location;
            txtNumero.Location = txtBanco.Location;
            lblNumero.Text = "Número do cartão";
            txtNumero.MaxLength = 20;
            txtNumero.Clear();

            lblDataDaTransacao.Location = lblAgencia.Location;
            dtpDataTransacao.Location = txtAgencia.Location;
            lblValor.Location = lblConta.Location;
            txtValor.Location = txtConta.Location;
            lblParcelas.Location = new Point(lblValor.Location.X, lblValor.Location.Y+35);
            cmbParcelas.Location = new Point(txtValor.Location.X, txtValor.Location.Y+35);

            cmbParcelas.Items.Clear();
            AddDiaParcelas();
            cmbParcelas.SelectedIndex = 0;


        }
        #endregion

        #region CadastraNoBanco
        private void CadastraBanco(string ChequeOuCartao)
        {
            DateTime DataUsada;
            String ProximaTransacao;

            var conn = new MySqlConnection(connString);
            MySqlCommand com1 = new MySqlCommand("SELECT MAX(cd_transacao)+1 from transacao;", conn);
            conn.Open();

            var result1 = com1.ExecuteReader();
            result1.Read();
            ProximaTransacao = result1[0].ToString();
            if (ProximaTransacao == "")
                ProximaTransacao = "1";

            result1.Close();
            result1.Dispose();

            MySqlCommand com = new MySqlCommand("Insert into transacao values(@ProxTransacao,'@nmpessoa',@cdtipopagamento,@vltransacao,'@dttransacao',@qtparcelas,'@dstransacao');", conn);
            com.CommandText = com.CommandText.Replace("@ProxTransacao", ProximaTransacao);
            com.CommandText = com.CommandText.Replace("@nmpessoa", txtNomeCliente.Text);
            com.CommandText = com.CommandText.Replace("@cdtipopagamento", cmbTipoPagamento.SelectedIndex.ToString());

            if (Valor.Length == 1)
            {
                com.CommandText = com.CommandText.Replace("@vltransacao", Valor + ".00");
            }
            else
                if (Valor.Length == 3)
                {
                    com.CommandText = com.CommandText.Replace("@vltransacao", Valor + "0");
                }
                else
                {
                    com.CommandText = com.CommandText.Replace("@vltransacao", Valor);
                }

            DataUsada = Convert.ToDateTime(dtpDataTransacao.Text);
            com.CommandText = com.CommandText.Replace("@dttransacao", DataUsada.Year + "/" + DataUsada.Month + "/" + DataUsada.Day);

            if (cmbTipoPagamento.SelectedIndex == 0)
                com.CommandText = com.CommandText.Replace("@qtparcelas", cmbParcelas.Text);
            else
                if (cmbTipoPagamento.SelectedIndex == 1)
                    com.CommandText = com.CommandText.Replace("@qtparcelas", "0");
                else
                {
                    if (cmbParcelas.Text == "À vista")
                        com.CommandText = com.CommandText.Replace("@qtparcelas", "0");
                    else
                        com.CommandText = com.CommandText.Replace("@qtparcelas", cmbParcelas.Text);
                }

            if (ChequeOuCartao == "Cartão")
                ChequeOuCartao = "Bandeira: " + txtEmpresa.Text + " | Número do cartão: " + txtNumero.Text;
            else
                ChequeOuCartao = "Empresa: " + txtEmpresa.Text + " | Banco: " + txtBanco.Text + " | Agência: " + txtAgencia.Text + " | Conta: " + txtConta.Text + " | Número do cheque: " + txtNumero.Text;

            com.CommandText = com.CommandText.Replace("@dstransacao", ChequeOuCartao);

            var result = com.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

            if (ChequeOuCartao.Contains("Bandeira"))
                MessageBox.Show("Cartão registrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cheque registrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaTela();
        }
        #endregion

        #endregion

    }
}
