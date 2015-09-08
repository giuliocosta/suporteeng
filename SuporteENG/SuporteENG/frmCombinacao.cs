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
    public partial class frmCombinacao : Form
    {
        public frmCombinacao()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    ClassCombinacao c = new ClassCombinacao();
                    c.NOME = txtDescricao.Text;
                    c.SUBSISTEMAID = int.Parse(txtSubsistema.Text);
                    c.NovaCombinacao();

                    txtDescricao.Text = "";
                    txtId.Text = "";

                    dtgCombinacao.DataSource = c.visualizarTodasCombinacaoNomeSub();
                    MessageBox.Show("Nome de combinação cadastrado com sucesso !");
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

        private void frmCombinacao_Load(object sender, EventArgs e)
        {
            try
            {
                ClassCombinacao c = new ClassCombinacao();
                dtgCombinacao.DataSource = c.visualizarTodasCombinacaoNomeSub();

                ClassSubsistemas s = new ClassSubsistemas();
                DataTable dt = s.visualizarTodosSubsistemas();

                cmbSubsistema.DataSource = dt;
                cmbSubsistema.DisplayMember = "nome";
                cmbSubsistema.ValueMember = "id";
                cmbSubsistema.Text = "Selecione...";
                txtSubsistema.Text = "";


                

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
                ClassCombinacao c = new ClassCombinacao();
                c.IDCOMBINACAO = int.Parse(txtId.Text);
                c.NOME = txtDescricao.Text;
                c.SUBSISTEMAID = int.Parse(txtSubsistema.Text);
                c.AlterarCombinacao();

                txtDescricao.Text = "";
                txtId.Text = "";

                dtgCombinacao.DataSource = c.visualizarTodasCombinacaoNomeSub();
                MessageBox.Show("Nome de combinação alterado com sucesso !");

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
                ClassCombinacao c = new ClassCombinacao();
                c.IDCOMBINACAO = int.Parse(txtId.Text);
                c.ExcluirCombinacao();

                txtDescricao.Text = "";
                txtId.Text = "";

                dtgCombinacao.DataSource = c.visualizarTodasCombinacaoNomeSub();
                MessageBox.Show("Nome de combinação excluída com sucesso !");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtgCombinacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dtgCombinacao.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescricao.Text = dtgCombinacao.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSubsistema.Text = dtgCombinacao.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbSubsistema.Text = dtgCombinacao.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtId.Text = "";
            cmbSubsistema.Text = "Selecione...";
            txtSubsistema.Text = "";
        }

        private void cmbSubsistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSubsistema.Text = cmbSubsistema.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}