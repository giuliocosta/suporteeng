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
    public partial class frmKit : Form
    {
        public frmKit()
        {
            InitializeComponent();
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtId.Text = "";
            txtPesquisa.Text = "";
            txtCC.Text = "";
            cmbCombinacao.Text = "Selecione...";
        }

        private void frmKit_Load(object sender, EventArgs e)
        {
            try
            {
                ClassKit k = new ClassKit();
                dtgKit.DataSource = k.visualizarTodosKits();

                ClassCombinacao c = new ClassCombinacao();
                DataTable dt = c.visualizarTodasCombinacao();

                cmbCombinacao.DataSource = dt;
                cmbCombinacao.DisplayMember = "nome";
                cmbCombinacao.ValueMember = "id";
                cmbCombinacao.Text = "Selecione...";
                txtCC.Text = "";
                
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
                if (txtId.Text == "")
                {
                    ClassKit k = new ClassKit();
                    k.DESCRICAO = txtDescricao.Text;
                    k.COMBINACAOID = int.Parse(cmbCombinacao.SelectedValue.ToString());
                    k.NovoKit();

                    txtDescricao.Text = "";
                    txtId.Text = "";
                    txtPesquisa.Text = "";

                    dtgKit.DataSource = k.visualizarTodosKits();
                    MessageBox.Show("Kit cadastrado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Limpe os campos para incluir um kit.");
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
                txtId.Text = dtgKit.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescricao.Text = dtgKit.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCC.Text = dtgKit.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCombinacao.Text = dtgKit.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                ClassKit k = new ClassKit();
                k.IDKIT = int.Parse(txtId.Text);
                k.ExcluirCombinacao();

                txtDescricao.Text = "";
                txtId.Text = "";
                txtPesquisa.Text = "";

                dtgKit.DataSource = k.visualizarTodosKits();
                MessageBox.Show("Kit excluído com sucesso !");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCombinacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCC.Text = cmbCombinacao.SelectedValue.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassKit k = new ClassKit();
                k.COMBINACAOID = int.Parse(txtCC.Text);
                k.DESCRICAO = txtDescricao.Text;
                k.IDKIT = int.Parse(txtId.Text);               
                k.AlterarKit();

                txtDescricao.Text = "";
                txtId.Text = "";
                txtPesquisa.Text = "";

                dtgKit.DataSource = k.visualizarTodosKits();
                MessageBox.Show("Kit editado com sucesso !");
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
                ClassKit k = new ClassKit();

                switch (cmbCampos.Text)
                {
                    case "Id":
                        k.IDKIT = int.Parse(txtPesquisa.Text);
                        dtgKit.DataSource = k.visualizarTodosKitsId();
                        break;
                    case "Descrição":
                        k.DESCRICAO = txtPesquisa.Text;
                        dtgKit.DataSource = k.visualizarTodosKitsDesc();
                        break;
                    case "Combinação":
                        k.COMBINACAONOME = txtPesquisa.Text;
                        dtgKit.DataSource = k.visualizarTodosKitsComb();
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
