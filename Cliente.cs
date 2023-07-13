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
    public partial class frmCliente : Form
    {

        private void CarregarUsuario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM `usuariocompleto` WHERE Usuario = 'Outro' ORDER BY Status = 'INATIVO'";



                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Clientes. \n\n" + ex.Message);
            }
        }

        private void CarregarUsuarioAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuarioativo WHERE Usuario = 'Outro'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Clientes Ativos. \n\n" + ex.Message);
            }
        }

        private void CarregarUsuarioInativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuarioinativo WHERE Usuario = 'Outro'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Clientes inativos. \n\n" + ex.Message);
            }
        }


        private void CarregarUsuarioNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuariocompleto WHERE `Nome` LIKE '%" + Variaveis.nomeUsuario + "%' AND Usuario = 'Outro';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Clientes. \n\n" + ex.Message);
            }
        }


        private void ExcluirUsuario()
        {
            try
            {
                Banco.Conectar();
                string excluir = "DELETE FROM `usuario` WHERE idUsuario = @codUsuario";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codUsuario", Variaveis.codUsuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso!");
                Banco.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Cliente. \n\n" + ex.Message);
            }
        }






        public frmCliente()
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            pnlCliente.Location = new Point(this.Width / 2 - pnlCliente.Width / 2, this.Height / 2 - pnlCliente.Height / 2);

            CarregarUsuario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadCliente().Show();
            Hide();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void btnAgendamento_Click_1(object sender, EventArgs e)
        {
            new frmAgendamento().Show();
            Close();
        }

        private void btnSobre_Click_1(object sender, EventArgs e)
        {
            new frmSobre().Show();
            Close();
        }

        private void btnAjuda_Click_1(object sender, EventArgs e)
        {
            new frmAjuda().Show();
            Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
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

        private void btnSair_Click_2(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCliente_Click_2(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void btnFuncionario_Click_2(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void btnAgendamento_Click_2(object sender, EventArgs e)
        {
            new frmAgendamento().Show();
            Close();
        }

        private void btnSobre_Click_2(object sender, EventArgs e)
        {
            new frmSobre().Show();
            Close();
        }

        private void btnAjuda_Click_2(object sender, EventArgs e)
        {
            new frmAjuda().Show();
            Close();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadCliente().Show();
            Close();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaselecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaselecionada >= 0)
            {
                Variaveis.codUsuario = Convert.ToInt32(dgvCliente[0, Variaveis.linhaselecionada].Value);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarUsuarioAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarUsuarioInativo();
            }
            else
            {
                CarregarUsuario();
            }
        }

        private void txtCliente_TextChanged_1(object sender, EventArgs e)
        {
            Variaveis.nomeUsuario = txtCliente.Text;


            if (Variaveis.nomeUsuario == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "";
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "";
                CarregarUsuarioNome();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (Variaveis.linhaselecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Para alterar uma linha");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaselecionada >= 0)
            {
                dgvCliente.Rows[Variaveis.linhaselecionada].Selected = true;
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirUsuario();
                    new frmCliente().Show();
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
