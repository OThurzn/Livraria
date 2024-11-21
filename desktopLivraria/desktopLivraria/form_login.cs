using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopLivraria
{
    public partial class fomr_login : Form
    {
        public fomr_login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = "admin@etec.com";
            string senha = "123";

            if (txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                Form_principal formulario = new Form_principal();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalido");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Exemplo Projeto",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); ;
            }
        }
    }
}
