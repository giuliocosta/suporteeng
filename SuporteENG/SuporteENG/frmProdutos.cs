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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ClassProdutos p = new ClassProdutos();            
            dtgProdutos.DataSource = p.visualizarTodosProdutos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    ClassProdutos p = new ClassProdutos();
                    p.CODPRODUTO = txtCodigo.Text;
                    p.DESCRICAO = txtDescricao.Text;
                    p.VALOR = double.Parse(txtPreco.Text);
                    p.NovoProduto();

                    txtCodigo.Text = "";
                    txtDescricao.Text = "";
                    txtId.Text = "";
                    txtPreco.Text = "";

                    dtgProdutos.DataSource = p.visualizarTodosProdutos();
                    MessageBox.Show("Produto cadastrado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Limpe os campos para incluir um produto.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtCodigo.Text = dtgProdutos.Rows[e.RowIndex].Cells["codproduto"].Value.ToString();
            txtDescricao.Text = dtgProdutos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtPreco.Text = dtgProdutos.Rows[e.RowIndex].Cells["valor"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassProdutos p = new ClassProdutos();
                p.IDPRODUTO = int.Parse(txtId.Text);
                p.CODPRODUTO = txtCodigo.Text;
                p.DESCRICAO = txtDescricao.Text;
                p.VALOR = double.Parse(txtPreco.Text);
                p.AlterarProduto();

                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtId.Text = "";
                txtPreco.Text = "";

                dtgProdutos.DataSource = p.visualizarTodosProdutos();
                MessageBox.Show("Produto alterado com sucesso !");
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
                ClassProdutos p = new ClassProdutos();
                p.IDPRODUTO = int.Parse(txtId.Text);
                p.ExcluirProduto();

                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtId.Text = "";
                txtPreco.Text = "";

                dtgProdutos.DataSource = p.visualizarTodosProdutos();
                MessageBox.Show("Produto excluído com sucesso !");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtId.Text = "";
            txtPreco.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassProdutos p = new ClassProdutos();
                switch (cmbCampos.Text)
                {
                    case "Id":
                        p.IDPRODUTO = int.Parse(txtPesquisa.Text);
                        dtgProdutos.DataSource = p.PesquisarProdutoID();
                        break;
                    case "Código":
                        p.CODPRODUTO = txtPesquisa.Text;
                        dtgProdutos.DataSource = p.PesquisarProdutoCodigo();
                        break;
                    case "Descrição":
                        p.DESCRICAO = txtPesquisa.Text;
                        dtgProdutos.DataSource = p.PesquisarProdutoDescricao();
                        break;
                    default:
                        MessageBox.Show("Escolha uma categoria !");
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
        }
    }

