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
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;

namespace ProjetoTeste
{
    public partial class frmFuncionario : Form
    {


        private void CarregarFuncionario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM `usuariocompleto` WHERE Usuario = 'Administrador' ORDER BY Status = 'INATIVO'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionarioo.DataSource = dt;

                dgvFuncionarioo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Funcionários. \n\n" + ex.Message);
            }
        }

        private void CarregarFuncionarioAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuarioativo WHERE Usuario = 'Administrador'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionarioo.DataSource = dt;

                dgvFuncionarioo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Funcionarios ativos. \n\n" + ex.Message);
            }
        }

        private void CarregarFuncionarioInativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuarioinativo WHERE Usuario = 'Administrador'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionarioo.DataSource = dt;

                dgvFuncionarioo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios inativos. \n\n" + ex.Message);
            }
        }



        private void CarregarFuncionarioNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuariocompleto WHERE `Nome` LIKE '%" + Variaveis.nomeUsuario + "%' AND Usuario = 'Administrador';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionarioo.DataSource = dt;

                dgvFuncionarioo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios. \n\n" + ex.Message);
            }
        }



        private void ExcluirFuncionario()
        {
            try
            {
                Banco.Conectar();
                string excluir = "DELETE FROM `usuario` WHERE idUsuario = @codUsuario";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codUsuario", Variaveis.codUsuario);
                cmd.ExecuteNonQuery();
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Funcionario. \n\n" + ex.Message);
            }
        }





        public frmFuncionario()
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            new frmAgendamento().Show();
            Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            new frmSobre().Show();
            Close();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            new frmAjuda().Show();
            Close();
        }

        private void pnlFuncionario_Paint(object sender, PaintEventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Variaveis.nomeUsuario = txtFuncionario.Text;


            if (Variaveis.nomeUsuario == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "";
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "";
                CarregarFuncionarioNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarFuncionarioAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarFuncionarioInativo();
            }
            else
            {
                CarregarFuncionario();
            }
        }

        private void btnCadastrarr_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaselecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadFuncionario().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Para alterar é necessário selecionar uma linha.");
            }
        }

        private void dgvFuncionarioo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaselecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaselecionada >= 0)
            {
                Variaveis.codUsuario = Convert.ToInt32(dgvFuncionarioo[0, Variaveis.linhaselecionada].Value);
            }
        }

        private void btnExcluirr_Click_1(object sender, EventArgs e)
        {
            if (Variaveis.linhaselecionada >= 0)
            {
                dgvFuncionarioo.Rows[Variaveis.linhaselecionada].Selected = true;
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirFuncionario();
                    new frmFuncionario().Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir");
            }
        }
    }
}
