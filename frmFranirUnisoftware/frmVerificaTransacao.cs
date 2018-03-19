using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace frmVerificaTransacao
{
    public partial class frmVerificaTransacao : Form
    {
        public frmVerificaTransacao()
        {
            InitializeComponent();
            TopLevel = false;
        }

        #region Variáveis
        private string connString = "server=localhost;username=root;pwd=root;database=franirunisoftware"; //String de conexão com o banco
        private double totalPeriodo;
        private List<List<string>> IndiceGrid = new List<List<string>>();
        #endregion

        #region frmLoad
        private void frmVerificaTransacao_Load(object sender, EventArgs e)
        {
            rdbPeriodo.Checked = true;
            cmbMes.Items.Clear();
            for (int i = 1; i < 13; i++)
            { 
                cmbMes.Items.Add(i);
            }
            for (int i = 2016; i < 2101; i++)
            {
                cmbAno.Items.Add(i);
            }
        }
        #endregion

        #region rdbOnChange

        #region rdbPeriodo
        private void rdbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            rdbPeriodo.TabStop = true;

            if (rdbPeriodo.Checked)
            {
                lblPeriodoOuMes.Text = "Dê:";
                lblAte.Text = "Até:";

                lblAte.Visible = true;
                dtpDe.Visible = true;
                dtpAte.Visible = true;

                cmbMes.Visible = false;
                cmbAno.Visible = false;
            }
        }
        #endregion

        #region rdbMes
        private void rdbMes_CheckedChanged(object sender, EventArgs e)
        {
            rdbMes.TabStop = true;
            if (rdbMes.Checked)
            {
                lblPeriodoOuMes.Text = "Selecione o mês: ";
                lblAte.Text = "Selecione o ano: ";
                lblAte.Visible = true;

                dtpDe.Visible = false;
                dtpAte.Visible = false;

                cmbMes.Visible = true;
                cmbAno.Visible = true;

                cmbMes.SelectedIndex = 0;
                cmbAno.SelectedIndex = 0;
            }
        }
        #endregion

        #region rdbCadastroDia
        private void rdbCadastroDia_CheckedChanged(object sender, EventArgs e)
        {
            rdbCadastroDia.TabStop = true;
            if (rdbCadastroDia.Checked)
            {
                lblPeriodoOuMes.Text = "Dia:";
                lblAte.Visible = false;
                dtpDe.Visible = true;
                dtpAte.Visible = false;


                cmbMes.Visible = false;
                cmbAno.Visible = false;
            }
        }
        #endregion

        #endregion

        #region Botões

        #region btnVerificar
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            DateTime DataCadastrada;
            DateTime DataParcela;
            string WhereConcat;
            int Linha = 0;
            totalPeriodo = 0;

            dtgTransacoes.Rows.Clear();

            var conn = new MySqlConnection(connString);
            MySqlCommand com = new MySqlCommand("SELECT nm_pessoa_transacao, cd_tipo_pagamento, dt_transacao, qt_parcelas_transacao, vl_transacao, ds_transacao, cd_transacao from transacao", conn);
            IndiceGrid.Clear();

            if (rdbPeriodo.Checked) //Verifica qual rdb está checada
            {
                #region TransaçõesPorPeríodo

                DateTime PeriodoDe = Convert.ToDateTime(dtpDe.Text);
                DateTime PeriodoAte = Convert.ToDateTime(dtpAte.Text);

                if (PeriodoDe <= PeriodoAte) //Verifica se o Periodo Dê é menor ou igual ao Periodo Até
                {
                   
                    WhereConcat = " Where dt_transacao >= '" + PeriodoDe.Year + "/" + PeriodoDe.Month + "/" + PeriodoDe.Day + "' AND dt_transacao <= '" + PeriodoAte.Year + "/" + PeriodoAte.Month + "/" + PeriodoAte.Day + "'";

                    com.CommandText = com.CommandText + WhereConcat +  " ORDER BY 3;";
                    conn.Open();
                    var result = com.ExecuteReader();

                    while (result.Read())
                    {
                        DataCadastrada = Convert.ToDateTime(result[2].ToString());
                        if (result[3].ToString() == "0") //Verifica é avista ou parcelado
                        {
                                ColocaGrid(result, 0, DataCadastrada, DataCadastrada, ref Linha);
                        }
                        else //É crédito ou cheque parcelado
                        {
                            for (int i = 0; i < Convert.ToInt16(result[3].ToString()); i++) // Cada loop significa 1 parcela, ele pega o read e vai indo e verificando se aqla parcela está de acordo com o periodo desejado
                            {
                                DataParcela = DataCadastrada.AddDays(i * 30);
                                if (DataParcela >= PeriodoDe && DataParcela <= PeriodoAte)
                                {
                                    ColocaGrid(result, i+1, DataCadastrada, DataParcela, ref Linha);
                                }
                            }
                        }
                        
                    }

                    result.Close();
                    result.Dispose();

                    if (Linha == 0) // Se nenhum dado foi encontrado dá um aviso q nenhuma transação foi encontrada naquele mes
                    {
                        MessageBox.Show("Nenhuma transação encontrada durante o período selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExportarExcel.Enabled = false;
                        btnExcluirTransacao.Enabled = false;
                    }
                    else
                    {
                        btnExcluirTransacao.Enabled = true;
                        btnExportarExcel.Enabled = true;
                    }
                }

                else
                {
                    MessageBox.Show("O período DE deve ser menor que o período de ATÉ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnExportarExcel.Enabled = false;
                    btnExcluirTransacao.Enabled = false;
                }

                #endregion
            }
            else
                if (rdbMes.Checked)
                {
                    #region TransaçõesPorMês
                    string MesParcela;
                    string AnoParcela;

                    MesParcela = cmbMes.Text;
                    AnoParcela = cmbAno.Text;

                   // WhereConcat = " Where month(dt_transacao) = '" +MesParcela +"' and year(dt_transacao) = '" +AnoParcela +"'";

                    com.CommandText = com.CommandText + " ORDER BY 3;";
                    conn.Open();
                    var result = com.ExecuteReader();

                    while (result.Read())
                    {
                        DataCadastrada = Convert.ToDateTime(result[2].ToString());
                        if (result[3].ToString() == "0") //Verifica se é cheque avista
                            {
                                if ((Int32.Parse(MesParcela) == DataCadastrada.Month) && (Int32.Parse(AnoParcela) == DataCadastrada.Year))
                                    ColocaGrid(result, 0, DataCadastrada, DataCadastrada, ref Linha);
                            }
                            else //É cartão de crédito ou cheque Predatado
                            {
                                for (int i = 0; i < Convert.ToInt16(result[3].ToString()); i++) //Pra cada parcela que aquele Read tem ele:
                                {
                                    DataParcela = DataCadastrada.AddDays(i * 30); // Pega a data da parcela e multiplica com 30 pra cada loop
                                    if (( Int32.Parse(MesParcela) == DataParcela.Month) && (Int32.Parse(AnoParcela) == DataParcela.Year))
                                        ColocaGrid(result, i+1, DataCadastrada, DataParcela, ref Linha);
                                }
                            }
                    }

                    result.Close();
                    result.Dispose();

                    if (Linha == 0) // Se nenhum dado foi encontrado dá um aviso q nenhuma transação foi encontrada naquele mes
                    {
                        MessageBox.Show("Nenhuma transação encontrada nesse mês", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExcluirTransacao.Enabled = false;
                        btnExportarExcel.Enabled = false;
                    }
                    else
                    {
                        btnExcluirTransacao.Enabled = true;
                        btnExportarExcel.Enabled = true;
                    }

                    #endregion
                }
                else
                {
                    #region TransaçõesDiaEfetuado

                    DateTime TransacoesDiaEfetuado = Convert.ToDateTime(dtpDe.Text);

                    WhereConcat = " Where dt_transacao = '"+TransacoesDiaEfetuado.Year+"/"+TransacoesDiaEfetuado.Month+"/"+TransacoesDiaEfetuado.Day+"'";

                    com.CommandText = com.CommandText +WhereConcat+ " ORDER BY 3;";

                    conn.Open();
                    var result = com.ExecuteReader();
                    while (result.Read())
                    {
                        DataCadastrada = Convert.ToDateTime(result[2].ToString()); //Converte a data
                        string QTparcelas=result[3].ToString();
                        ColocaGrid(result, Convert.ToInt16(QTparcelas), DataCadastrada, DataCadastrada, ref Linha);
                    }

                    result.Close();
                    result.Dispose();

                    if (Linha == 0) // Se nenhum dado foi encontrado dá um aviso q nenhuma transação foi encontrada naquele mes
                    {
                        MessageBox.Show("Nenhuma transação encontrada durante o período selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExportarExcel.Enabled = false;
                        btnExcluirTransacao.Enabled = false;
                    }
                    else
                    {
                        btnExcluirTransacao.Enabled = true;
                        btnExportarExcel.Enabled = true;
                    }

                    #endregion
                }

            conn.Close();
            conn.Dispose();
            lblValorTotal.Text = totalPeriodo.ToString("C2");
        }
        #endregion

        #region btnExcluirTransacao
        private void btnExcluirTransacao_Click(object sender, EventArgs e)
        {
            int Linha = dtgTransacoes.SelectedRows.Count;

            if (Linha == 0) //Verifica se tem alguma linha na Grid
            {
                MessageBox.Show("Selecione uma linha antes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  // pergunta se o usuario tem certeza se quer excluir
                if (MessageBox.Show("Tem certeza que deseja excluir essa transação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    int LinhaDeletada = dtgTransacoes.CurrentRow.Index; // pega a linha atual

                    var conn = new MySqlConnection(connString);
                    MySqlCommand com = new MySqlCommand("DELETE FROM transacao WHERE cd_transacao=@codTransacao;", conn);
                    com.CommandText = com.CommandText.Replace("@codTransacao", dtgTransacoes[6, LinhaDeletada].Value.ToString());

                    conn.Open();

                    var result = com.ExecuteNonQuery();

                    conn.Close();
                    conn.Dispose();

                    MessageBox.Show("Transação deletada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnVerificar_Click(sender, e); // refresh na grid
                }
            }
        }
        #endregion

        #region btnExportar
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp != null)
                {
                    Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Worksheet ws = (Worksheet)wb.Worksheets[1];
                    if (ws != null)
                    {
                        var PegaRange = ws.get_Range("B2", "I2");
                        if (PegaRange != null)
                        {
                            string[] Conteudo;
                            string Celula;
                            double ValorBruto;
                            double ValorLiquido;

                            int Linha;
                            ValorBruto = 0;
                            ValorLiquido = 0;

                            Linha = 4;
                            Conteudo = new string[9];

                            //Titulo
                            #region Titulo

                            if (rdbPeriodo.Checked)
                            {
                                Conteudo[0] = "Transações entre o período de @DE a @ATE";
                                Conteudo[0] = Conteudo[0].Replace("@DE", dtpDe.Text.ToString());
                                Conteudo[0] = Conteudo[0].Replace("@ATE", dtpAte.Text.ToString());
                            }
                            else
                                if (rdbMes.Checked)
                                {
                                    Conteudo[0] = "Transações do @Mesº mes de @Ano";
                                    Conteudo[0] = Conteudo[0].Replace("@Mes", cmbMes.Text);
                                    Conteudo[0] = Conteudo[0].Replace("@Ano", cmbAno.Text);
                                }
                                else
                                {
                                    Conteudo[0] = "Movimento do dia @DIA";
                                    Conteudo[0] = Conteudo[0].Replace("@DIA", dtpDe.Text.ToString());
                                }

                            RangeExcel(ws, PegaRange, Conteudo[0], 15, Color.Red, "Titulo");

                            #endregion

                            //Menu
                            #region Menu

                            Conteudo[1] = "Nome do cliente";
                            Conteudo[2] = "Tipo da transação";
                            Conteudo[3] = "Data da transação";
                            Conteudo[4] = "Data da parcela";
                            Conteudo[5] = "Valor Bruto";
                            Conteudo[6] = "Parcelas";
                            Conteudo[7] = "Valor Líquido";
                            Conteudo[8] = "Descrição";


                            for (int i = 1; i < 9; i++)
                            {
                                Celula = char.ConvertFromUtf32(65 + i) + Linha.ToString();

                                PegaRange = ws.get_Range(Celula, Celula);
                                RangeExcel(ws, PegaRange, Conteudo[i], 10, Color.Red, "Menu");
                            }

                            #endregion

                            Linha++;

                            //Conteudo
                            #region Conteúdo
                            for (int i = 0; i < IndiceGrid.Count; i++)
                            {
                                for (int x = 0; x < 8; x++)
                                {
                                    Celula = char.ConvertFromUtf32(66 + x) + Linha;

                                    PegaRange = ws.get_Range(Celula, Celula);

                                    if (x == 4)
                                    {
                                        ValorBruto += Convert.ToDouble(IndiceGrid[i][x].ToString());
                                        RangeExcel(ws, PegaRange, IndiceGrid[i][x].ToString(), 10, Color.Black, "QuatroOuSeis");
                                    }
                                    else
                                        if (x == 6)
                                        {
                                            ValorLiquido += Convert.ToDouble(IndiceGrid[i][x].ToString());
                                            RangeExcel(ws, PegaRange, IndiceGrid[i][x].ToString(), 10, Color.Black, "QuatroOuSeis");
                                        }
                                    else
                                            RangeExcel(ws, PegaRange, IndiceGrid[i][x].ToString(), 10, Color.Black, "Dados");
                                }
                                Linha++;
                            }
                            #endregion

                            Linha++;

                            //Rodapé
                            #region Rodapé
                            Celula = "B" + Linha; ;
                            PegaRange = ws.get_Range(Celula, Celula);
                            RangeExcel(ws, PegaRange, "Total:", 10, Color.Red, "Menu");


                            Celula = "F"+Linha;;
                            PegaRange = ws.get_Range(Celula, Celula);
                            RangeExcel(ws, PegaRange, ValorBruto.ToString(), 10, Color.Black, "QuatroOuSeis");


                            Celula = "H" + Linha; ;
                            PegaRange = ws.get_Range(Celula, Celula);
                            RangeExcel(ws, PegaRange, ValorLiquido.ToString(), 10, Color.Black, "QuatroOuSeis");
                            #endregion
                            
                            xlApp.Visible = true;
                            //TIRAR DA MEMORIA O EXCEL KRL
                            //xlApp = null;
                            GC.Collect();
                        }
                        else
                            Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
                    }
                    else
                        Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
                }
                else
                    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
        }
        #endregion

        #endregion

        #region Métodos

        #region ColocaGrid
        private void ColocaGrid(MySqlDataReader result, int QualParcela,DateTime DataCadastrada, DateTime DataParcela, ref int Linha)
        {
            List<string> QuantidadeTransacoes = new List<string>();
            QuantidadeTransacoes.Clear();
            dtgTransacoes.Rows.Add(); //Adiciona Linha pois 1 transação foi encontrada

            dtgTransacoes[0, Linha].Value = result[0].ToString(); //Nome do cliente

            QuantidadeTransacoes.Add(result[0].ToString()); //Add nome do cliente na lista

            //Verifica se a tipo do pagamento
            if (result[1].ToString() == "0")
                if (result[3].ToString() == "1")
                {
                    dtgTransacoes[1, Linha].Value = "Crédito";
                    QuantidadeTransacoes.Add("Crédito");
                }
                else
                {
                    dtgTransacoes[1, Linha].Value = "Crédito parcelado";
                    QuantidadeTransacoes.Add("Crédito parcelado");
                }
            else
                if (result[1].ToString() == "1")
                {
                    dtgTransacoes[1, Linha].Value = "Débito";
                    QuantidadeTransacoes.Add("Débito");
                }
                else
                    if (result[3].ToString() == "0")
                    {
                        dtgTransacoes[1, Linha].Value = "Cheque";
                        QuantidadeTransacoes.Add("Cheque");
                    }
                    else
                    {
                        dtgTransacoes[1, Linha].Value = "Cheque pré-datado";
                        QuantidadeTransacoes.Add("Cheque pré-datado");
                    }


            QuantidadeTransacoes.Add(DataCadastrada.ToShortDateString());

            dtgTransacoes[2, Linha].Value = DataParcela.ToShortDateString(); //Data da Parcela
            QuantidadeTransacoes.Add(DataParcela.ToShortDateString());

            double ValorParcelado = Convert.ToDouble(result[4].ToString()) / Convert.ToDouble(result[3].ToString()); //Total Dividido Pela QT Parcelas
           

         //   double ValorBruto = Convert.ToDouble(result[4].ToString());

         //  QuantidadeTransacoes.Add(ValorBruto.ToString("f2"));                         //VALOR BRUTO
         //   QuantidadeTransacoes.Add(ValorParcelado.ToString("f2"));                         //VALOR BRUTO

            //Quantidade de Parcelas e Valor da Parcela
            if (result[1].ToString() == "1")
            {
                dtgTransacoes[3, Linha].Value = "Automático"; //Quantidade de Parcelas Débito

                ValorParcelado = Convert.ToDouble(result[4].ToString());
                QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));                    //BRUTO DA PARCELA
                ValorParcelado = (ValorParcelado * 95.50)/100;

                totalPeriodo += ValorParcelado;
                dtgTransacoes[4, Linha].Value = ValorParcelado.ToString("C2");//Valor Parcela

                QuantidadeTransacoes.Add("Automático");
                QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));    

            }
            else
                if (result[3].ToString() == "0")
                {
                    dtgTransacoes[3, Linha].Value = "À vista"; //QT Parcela Cheque À vista

                    ValorParcelado = Convert.ToDouble(result[4].ToString());
                    QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));                    //BRUTO DA PARCELA
                    ValorParcelado = (ValorParcelado * 95.50)/100;

                    totalPeriodo += ValorParcelado;
                    dtgTransacoes[4, Linha].Value = ValorParcelado.ToString("C2"); //Valor Parcela

                    QuantidadeTransacoes.Add("1");
                    QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));    
                }
                else
                        if (result[3].ToString() == "1")
                        { 
                            //credito
                            dtgTransacoes[3, Linha].Value = "1"; //QT Parcelas créditos a vista

                            ValorParcelado = Convert.ToDouble(result[4].ToString());
                            QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));                    //BRUTO DA PARCELA
                            ValorParcelado = (ValorParcelado * 95.50) / 100;

                            totalPeriodo += ValorParcelado;
                            dtgTransacoes[4, Linha].Value = ValorParcelado.ToString("C2"); //Valor Parcela

                            QuantidadeTransacoes.Add("1");
                            QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));    
                        }
                        else
                        {  //credito parcelado cheuqe prédatado
                            if (rdbCadastroDia.Checked)
                            {
                                ValorParcelado = Convert.ToDouble(result[4].ToString());
                                QuantidadeTransacoes.Add(ValorParcelado.ToString("F2")); //BRUTO DA PARCELA
                                ValorParcelado = (ValorParcelado * 95.50) / 100;
                                dtgTransacoes[3, Linha].Value = result[3].ToString();
                                dtgTransacoes[4, Linha].Value = ValorParcelado.ToString("C2"); //Valor Parcela
                                QuantidadeTransacoes.Add(result[3].ToString());
                            }
                            else
                            {
                                QuantidadeTransacoes.Add(ValorParcelado.ToString("F2")); //BRUTO DA PARCELA
                                ValorParcelado = (ValorParcelado * 95.50) / 100;
                                dtgTransacoes[3, Linha].Value = QualParcela + "ª de " + result[3].ToString() + " parcelas"; //QT Parcelas Crédito e Cheque
                                dtgTransacoes[4, Linha].Value = ValorParcelado.ToString("C2"); //Valor Parcela
                                QuantidadeTransacoes.Add(QualParcela + "ª de " + result[3].ToString() + " parcelas");
                            }
                           
                            totalPeriodo += ValorParcelado;
                            QuantidadeTransacoes.Add(ValorParcelado.ToString("F2"));  
                        }
           
            dtgTransacoes[5, Linha].Value = result[5].ToString(); // Descrição da transação
            QuantidadeTransacoes.Add(result[5].ToString());    

            dtgTransacoes[6, Linha].Value = result[6].ToString(); // Coloca o código da transação oculto caso queira deletar

            IndiceGrid.Add(QuantidadeTransacoes);

            Linha++; //Aumenta o contador de Linha
        }
        #endregion

        #region ColocaDadosExcel
        private void RangeExcel(Worksheet ws, Range PegaRange, string Conteudo, int Font, Color Cor, string TituloOuMenuQuatroOuSeis)
        {
            Range Range = PegaRange;

            if (TituloOuMenuQuatroOuSeis == "Titulo")
            {
                Range.MergeCells = true;
                Range.Font.Bold = true;
            }

            if (TituloOuMenuQuatroOuSeis == "Menu")
            {
                Range.Font.Bold = true;
            }
            //Altera Font
            Range.Font.Name = "Arial";
            Range.Font.Size = Font;
            Range.Font.Color = Cor;

            //Põe Borda Microsoft.Office.Interop.Excel.XlDataBarBorderType.xlDataBarBorderSolid;
            Range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            Range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

            //Alinhamento da Borda
            Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            //Põe Valor
            if (TituloOuMenuQuatroOuSeis == "QuatroOuSeis")
            {
                double ValorTransformado;
                ValorTransformado = Convert.ToDouble(Conteudo);
                Range.Value2 = ValorTransformado.ToString("C2");
            }
            else
                Range.Value2 = Conteudo;

            Range.EntireColumn.AutoFit();
        }
        #endregion

        #endregion

        
    }
}


