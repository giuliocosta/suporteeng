using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace SuporteENG
{
    public partial class frmConsultaOrcamento : Form
    {
        public frmConsultaOrcamento()
        {
            InitializeComponent();
        }

        private void frmConsultaOrcamento_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCampos.Text = "Selecione...";
                datePesquisa.Visible = false;
                ClassOrcamento o = new ClassOrcamento();
                dtgOrcamento.DataSource = o.Lista();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   

        }

        private void cmbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCampos.Text == "Data")
                {
                    datePesquisa.Visible = true;
                }
                else
                {
                    datePesquisa.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnPesID_Click(object sender, EventArgs e)
        {
            try
            {
                ClassItensOrcamento o = new ClassItensOrcamento();
                o.ORCAMENTOID = int.Parse(txtIdOrcamento.Text);
                DataTable dt = o.ListaItens();
                if (dt.Rows.Count != 0)
                {
                    dtgItensOr.DataSource = o.ListaItens();
                }
                else
                {
                    MessageBox.Show("Não existem itens para o orçamento solicitado !");
                    txtIdOrcamento.Focus();                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassOrcamento o = new ClassOrcamento();
                ClassItensOrcamento i = new ClassItensOrcamento();
                switch (cmbCampos.Text)
                {
                    case "Nome Cliente":
                        o.CLIENTE = txtPesquisa.Text;
                        dtgOrcamento.DataSource = o.ListaCliente();
                        break;
                    case"Data":
                        o.DATA = datePesquisa.Value.ToString("yyyy-MM-dd");
                        dtgOrcamento.DataSource = o.ListaData();
                        break;
                    default:
                        MessageBox.Show("Escolha uma opção válida !");
                        cmbCampos.Text = "Selecione...";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgOrcamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdOrcamento.Text = dtgOrcamento.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCliente.Text = dtgOrcamento.Rows[e.RowIndex].Cells[1].Value.ToString();                
                txtData.Text = dtgOrcamento.Rows[e.RowIndex].Cells[2].Value.ToString();
                ClassItensOrcamento i = new ClassItensOrcamento();
                i.ORCAMENTOID = int.Parse(txtIdOrcamento.Text);
                dtgItensOr.DataSource = i.ListaItens();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {


            try
            {
                saveFileDialog1.InitialDirectory = "C:";
                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*xlsx";

                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);
                    ExcelApp.Columns.ColumnWidth = 20;

                    for (int i = 1; i < dtgItensOr.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dtgItensOr.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dtgItensOr.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dtgItensOr.ColumnCount; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dtgItensOr.Rows[i].Cells[j].Value.ToString();
                        }
                    }        

                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
