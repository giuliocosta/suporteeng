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
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
        {
            InitializeComponent();
        }

        private void subsistemasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSubsistema s = new frmSubsistema();
            s.Show();
        }

        private void combinaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombinacao c = new frmCombinacao();
            c.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKit k = new frmKit();
            k.Show();
        }

        private void itensDoKitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItensKit i = new frmItensKit();
            i.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutos p = new frmProdutos();
            p.Show();
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamento o = new frmOrcamento();
            o.Show();
        }

        private void consultarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaOrcamento con = new frmConsultaOrcamento();
            con.Show();
        }
    }
}
