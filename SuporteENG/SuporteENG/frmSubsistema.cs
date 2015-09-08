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
    public partial class frmSubsistema : Form
    {
        public frmSubsistema()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    ClassSubsistemas s = new ClassSubsistemas();
                    s.NOME = txtNome.Text;
                    s.NovaSubsistema();

                    txtId.Text = "";
                    txtNome.Text = "";

                    dtgSubsistema.DataSource = s.visualizarTodosSubsistemas();
                    MessageBox.Show("Subsistema cadastrado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Limpe os campos para incluir um subsistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSubsistema_Load(object sender, EventArgs e)
        {
            try
            {
                ClassSubsistemas s = new ClassSubsistemas();
                dtgSubsistema.DataSource = s.visualizarTodosSubsistemas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgSubsistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dtgSubsistema.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgSubsistema.Rows[e.RowIndex].Cells[1].Value.ToString();                
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
                ClassSubsistemas s = new ClassSubsistemas();
                s.IDSUBSISTEMA = int.Parse(txtId.Text);
                s.NOME = txtNome.Text;
                s.AlterarSubsistema();

                txtId.Text = "";
                txtNome.Text = "";

                dtgSubsistema.DataSource = s.visualizarTodosSubsistemas();
                MessageBox.Show("Subsistema editado com sucesso !");
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
                ClassSubsistemas s = new ClassSubsistemas();
                s.IDSUBSISTEMA = int.Parse(txtId.Text);
                s.ExcluirSubsistema();

                txtId.Text = "";
                txtNome.Text = "";

                dtgSubsistema.DataSource = s.visualizarTodosSubsistemas();
                MessageBox.Show("Subsistema excluído com sucesso !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
        }
    }
}
