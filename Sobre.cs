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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void pnlSobre_Paint(object sender, PaintEventArgs e)
        {
            pnlSobre.Location = new Point(this.Width / 2 - pnlSobre.Width / 2, this.Height / 2 - pnlSobre.Height / 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAgendamento().Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmSobre().Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmAjuda().Show();
            Close();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {

        }
    }
}
