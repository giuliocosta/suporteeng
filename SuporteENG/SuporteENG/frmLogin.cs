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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "adm@tel")
            {
                frmMenuAdm adm = new frmMenuAdm();
                adm.Show();
                Hide();
            }
            else if (txtUsuario.Text == "usuario" && txtSenha.Text == "123@tel")
            {
                frmMenuFuncionario usu = new frmMenuFuncionario();
                usu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuário/Senha incorreto !");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
