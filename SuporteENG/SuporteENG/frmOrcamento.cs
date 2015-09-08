using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteENG
{
    public partial class frmOrcamento : Form
    {
        public frmOrcamento()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassKit k = new ClassKit();
                switch (cmbCampos.Text)
                {
                    case "Nome Kit":
                        k.DESCRICAO = txtPesquisa.Text;
                        dtgKit.DataSource = k.visualizarNome();
                        break;
                    case "Id Kit":
                        k.IDKIT = int.Parse(txtPesquisa.Text);
                        dtgKit.DataSource = k.visualizarId();
                        break;
                    default:
                        MessageBox.Show("Escolha uma opção de pesquisa válida");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgKit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdKit.Text = dtgKit.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgKit.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmOrcamento_Load(object sender, EventArgs e)
        {
            try
            {
                ClassKit k = new ClassKit();
                dtgKit.DataSource = k.visualizar();
                ClassSubsistemas s = new ClassSubsistemas();
                DataTable dt = s.visualizarTodosSubsistemas();

                cmbSubsistema.DataSource = dt;
                cmbSubsistema.DisplayMember = "nome";
                cmbSubsistema.ValueMember = "id";
                cmbSubsistema.Text = "Selecione...";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSubsistema_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubsistema.SelectedValue.ToString() != "")
                {
                    ClassCombinacao c = new ClassCombinacao();
                    c.SUBSISTEMAID = int.Parse(cmbSubsistema.SelectedValue.ToString());
                    DataTable dt = c.visualizarCombSubs();

                    cmbCombinacao.DataSource = dt;
                    cmbCombinacao.DisplayMember = "nome";
                    cmbCombinacao.ValueMember = "id";
                    cmbCombinacao.Text = "Selecione...";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCombinacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbCombinacao.SelectedValue.ToString() != "")
                {
                    ClassKit k = new ClassKit();
                    k.COMBINACAOID = int.Parse(cmbCombinacao.SelectedValue.ToString());
                    DataTable dt = k.visualizarKitCombinacao();

                    cmbKit.DataSource = dt;
                    cmbKit.DisplayMember = "descricao";
                    cmbKit.ValueMember = "id";
                    cmbKit.Text = "Selecione...";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassKit k = new ClassKit();
                k.IDKIT = int.Parse(cmbKit.SelectedValue.ToString());
                DataTable dt = k.visualizarId();
                txtIdKit.Text = dt.Rows[0].ItemArray[0].ToString();
                txtNome.Text = dt.Rows[0].ItemArray[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text != "")
                {
                    if (txtIdKit.Text != "")
                    {
                        if (txtQtd.Text != "")
                        {
                            ClassOrcamento o = new ClassOrcamento();
                            if (txtIdOrcamento.Text == "")
                            {
                                o.CLIENTE = txtCliente.Text;                                
                                string dateTime = DateTime.Now.ToString();
                                string d = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                                o.DATA = d;
                                o.NovoOrcamento();
                                DataTable numero = o.NumeroOrcamento();
                                txtIdOrcamento.Text = numero.Rows[0].ItemArray[0].ToString();
                                txtCliente.Enabled = false;
                            }

                            ClassItensKit i = new ClassItensKit();
                            i.KITID = int.Parse(txtIdKit.Text);
                            DataTable retorna = i.RetornoProdutos();
                            ClassItensOrcamento itensO = new ClassItensOrcamento();
                            for (int c = 0; c < retorna.Rows.Count; c++)
                            {
                                int a = int.Parse(retorna.Rows[c].ItemArray[0].ToString());
                                
                                bool venda = false;
                                int produto = 0;

                                if (dtgVenda.RowCount != 0)
                                {
                                    for (int r = 0; r < dtgVenda.RowCount; r++)
                                    {
                                        int b = int.Parse(dtgVenda.Rows[r].Cells[1].Value.ToString());                                        
                                        if (a == b)
                                        {
                                            produto = a;
                                            venda = true;
                                            break;
                                        }
                                    }
                                }

                                itensO.ORCAMENTOID = int.Parse(txtIdOrcamento.Text);

                                if (venda)
                                {
                                    itensO.PRODUTOSID = produto;
                                    itensO.QUANTIDADE = int.Parse(retorna.Rows[c].ItemArray[1].ToString()) * int.Parse(txtQtd.Text);
                                    itensO.AlterarProduto();

                                }
                                else
                                {                                   
                                    itensO.PRODUTOSID = int.Parse(retorna.Rows[c].ItemArray[0].ToString());
                                    itensO.QUANTIDADE = int.Parse(retorna.Rows[c].ItemArray[1].ToString()) * int.Parse(txtQtd.Text);

                                    itensO.NovosItens();
                                }

                                
                            }

                            dtgVenda.DataSource = itensO.ListaItens();
                            txtIdKit.Text = "";
                            txtNome.Text = "";
                            txtQtd.Text = "";
                            o.IDORCAMENTO = int.Parse(txtIdOrcamento.Text);

                            double t = 0;

                            for (int v = 0; v < dtgVenda.RowCount - 1; v++)
                            {                                
                                t += double.Parse(dtgVenda.Rows[v].Cells[4].Value.ToString());                                
                            }

                            txtTotal.Text = t.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Digite a quantidade antes de incluir !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Importe um kit antes de prosseguir !");
                    }
                }
                else {
                    MessageBox.Show("Digite o nome do cliente para prosseguir !"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
               this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrcamento nO = new frmOrcamento();
                nO.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQtdProd.Text != "" && int.Parse(txtQtdProd.Text) != 0)
                {
                    ClassItensOrcamento o = new ClassItensOrcamento();
                    o.PRODUTOSID = int.Parse(txtIdProd.Text);
                    o.ORCAMENTOID = int.Parse(txtIdOrcamento.Text);
                    o.QUANTIDADE = int.Parse(txtQtdProd.Text);
                    o.AlterarQuantidade();

                    dtgVenda.DataSource = o.ListaItens();
                }
                else
                {
                    MessageBox.Show("O campo quantidade não pode ser nulo/vazio !");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdProd.Text = dtgVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNomeProd.Text = dtgVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQtdProd.Text = dtgVenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            txtNomeProd.Text = "";
            txtQtdProd.Text = "";
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ClassItensOrcamento o = new ClassItensOrcamento();
                o.PRODUTOSID = int.Parse(txtIdProd.Text);
                o.ORCAMENTOID = int.Parse(txtIdOrcamento.Text);
                o.QUANTIDADE = int.Parse(txtQtdProd.Text);
                o.ExcluirProdutoItem();

                dtgVenda.DataSource = o.ListaItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}