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
    public partial class frmMenuFuncionario : Form
    {
        public frmMenuFuncionario()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrcamento o = new frmOrcamento();
                o.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void consultarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaOrcamento con = new frmConsultaOrcamento();
            con.Show();
        }
    }
}
