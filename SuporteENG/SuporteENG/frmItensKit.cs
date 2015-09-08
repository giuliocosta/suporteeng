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
    public partial class frmItensKit : Form
    {
        public frmItensKit()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassItensKit i = new ClassItensKit();
                switch (cmbCampos.Text)
                {
                    case "Id Itens":
                        i.IDITENS = int.Parse(txtPesquisa.Text);
                        dtgItensKit.DataSource = i.visualizarTodosItensKitId();
                        break;
                    case "Nome Produto":
                        i.DESCRICAOCONSULTA = txtPesquisa.Text;
                        dtgItensKit.DataSource = i.visualizarTodosItensKitProduto();
                        break;
                    case "Nome Kit":
                        i.DESCRICAOCONSULTA = txtPesquisa.Text;
                        dtgItensKit.DataSource = i.visualizarTodosItensKitNome();
                        break;
                    case "Id Kit":
                        i.KITID = int.Parse(txtPesquisa.Text);
                        dtgItensKit.DataSource = i.visualizarTodosItensKitIdKit();
                        break;
                    case "Id Produto":
                        i.PRODUTOSID = int.Parse(txtPesquisa.Text);
                        dtgItensKit.DataSource = i.visualizarTodosItensKitIdProduto();
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

        private void frmItensKit_Load(object sender, EventArgs e)
        {
            try
            {
                
                ClassProdutos p = new ClassProdutos();
                ClassItensKit i = new ClassItensKit();
                dtgItensKit.DataSource = i.visualizarTodosItensKit();

                cmbCampos.Text = "Selecione...";
                DataTable dt = i.visualizarKit();

                cmbKit.DataSource = dt;
                cmbKit.DisplayMember = "descricao";
                cmbKit.ValueMember = "id";
                cmbKit.Text = "Selecione...";
                txtKit.Text = "";

                DataTable dt1 = p.visualizarTodosProdutos();

                cmbProduto.DataSource = dt1;
                cmbProduto.DisplayMember = "descricao";
                cmbProduto.ValueMember = "id";
                cmbProduto.Text = "Selecione...";
                txtProd.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            cmbProduto.Text = "Selecione...";
            cmbKit.Text = "Selecione...";
            cmbCampos.Text = "Selecione...";
            txtQtd.Text = "";
            txtProd.Text = "";
            txtKit.Text = "";
            txtIdItens.Text = "";
        }

        private void cmbKit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKit.Text = cmbKit.SelectedValue.ToString();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProd.Text = cmbProduto.SelectedValue.ToString();
        }

        private void dtgItensKit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdItens.Text = dtgItensKit.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProd.Text = dtgItensKit.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbProduto.Text = dtgItensKit.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQtd.Text = dtgItensKit.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtKit.Text = dtgItensKit.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbKit.Text = dtgItensKit.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdItens.Text == "")
                {
                    ClassItensKit i = new ClassItensKit();
                    i.KITID = int.Parse(txtKit.Text);
                    i.PRODUTOSID = int.Parse(txtProd.Text);
                    i.QUANTIDADE = int.Parse(txtQtd.Text);
                    i.NovoItensKit();

                    cmbProduto.Text = "Selecione...";
                    cmbKit.Text = "Selecione...";
                    cmbCampos.Text = "Selecione...";
                    txtQtd.Text = "";
                    txtProd.Text = "";
                    txtKit.Text = "";
                    txtIdItens.Text = "";

                    dtgItensKit.DataSource = i.visualizarTodosItensKit();
                    MessageBox.Show("Resgistro cadastrado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Limpe os campos antes de inserir um novo registro !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassItensKit i = new ClassItensKit();
                i.IDITENS = int.Parse(txtIdItens.Text);
                i.KITID = int.Parse(txtKit.Text);
                i.PRODUTOSID = int.Parse(txtProd.Text);
                i.QUANTIDADE = int.Parse(txtQtd.Text);
                i.AlterarItensKit();

                cmbProduto.Text = "Selecione...";
                cmbKit.Text = "Selecione...";
                cmbCampos.Text = "Selecione...";
                txtQtd.Text = "";
                txtProd.Text = "";
                txtKit.Text = "";
                txtIdItens.Text = "";

                dtgItensKit.DataSource = i.visualizarTodosItensKit();
                MessageBox.Show("Registro alterado com sucesso !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClassItensKit i = new ClassItensKit();
                i.IDITENS = int.Parse(txtIdItens.Text);
                i.ExcluirItensKit();

                cmbProduto.Text = "Selecione...";
                cmbKit.Text = "Selecione...";
                cmbCampos.Text = "Selecione...";
                txtQtd.Text = "";
                txtProd.Text = "";
                txtKit.Text = "";
                txtIdItens.Text = "";

                dtgItensKit.DataSource = i.visualizarTodosItensKit();
                MessageBox.Show("Registro excluído com sucesso !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
