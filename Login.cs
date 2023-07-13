using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Variaveis.usuario = txtEmail.Text;
            Variaveis.senha = txtSenha.Text;

            if (Variaveis.usuario == "Victor" && Variaveis.senha == "1234")
            {
                Variaveis.tpUsuario = "Administrador";
                new frmMenu().Show();
                Hide();
            }
            else if (Variaveis.usuario == "Eric" && Variaveis.senha == "1234")
            {
                Variaveis.tpUsuario = "Administrador";
                new frmMenu().Show();
                Hide();
            }
            else
            {
                try
                {
                    Banco.Conectar();
                    string selecionar = "SELECT `idUsuario`, `nomeUsuario`, `fkTpUsuario`, `statusUsuario`, `emailUsuario`, `senhaUsuario`, `cpfUsuario`, `telefoneUsuario` FROM `usuario` WHERE `emailUsuario` =@usuario AND `senhaUsuario` =@senha AND `fkTpUsuario` = 1 AND `statusUsuario` = 'ATIVO'";


                    MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                    cmd.Parameters.AddWithValue("@usuario", Variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        Variaveis.usuario = reader.GetString(4);
                        Variaveis.senha = reader.GetString(5);
                        new frmMenu().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao selecionar Usuário de login" + ex, "ERRO");
                }
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja me   smo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);

            txtEmail.Focus();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        
    }
}
