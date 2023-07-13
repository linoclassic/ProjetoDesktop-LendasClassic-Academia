using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class frmCadAgendamento : Form
    {

        int codigo;
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pnlCadAgendamento_Paint(object sender, PaintEventArgs e)
        {
            pnlCadAgendamento.Location = new Point(this.Width / 2 - pnlCadAgendamento.Width / 2, this.Height / 2 - pnlCadAgendamento.Height / 2);
        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            //CODIGO
            codigo = 1;
            txtCodigo.Text = codigo.ToString();
        }

        private void btnCadastrarAgendamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Realizado com SUCESSO !!");

            btnExcluirAgendamento.PerformClick();

            codigo = codigo + 1;
            txtCodigo.Text = codigo.ToString();
        }

        private void btnExcluirAgendamento_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtSobrenome.Text = String.Empty;
        }
    }
}
