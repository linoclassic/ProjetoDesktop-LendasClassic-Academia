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
    public partial class frmMenu : Form
    {
        private void CarregarUsuario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM `usuariocompleto` WHERE Usuario = 'Outro'";

                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

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

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

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

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Clientes inativos. \n\n" + ex.Message);
            }
        }



        private void CarregarFuncionario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `Código`, `Nome`, `Status`, `Email`, `Senha`, `CPF`, `Telefone` FROM usuariocompleto WHERE Usuario = 'Administrador'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Funcionarios ativos. \n\n" + ex.Message);
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

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

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

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de funcionarios inativos. \n\n" + ex.Message);
            }
        }


        private void CarregarAgendamento()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM reservacompleta";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Agendamentos Ativos. \n\n" + ex.Message);
            }
        }

        private void CarregarAgendamentoAtivo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM reservaativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Agendamentos Ativos. \n\n" + ex.Message);
            }
        }

        private void CarregarAgendamentoInativo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM reservainativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;

                dgvRelatorio.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Agendamentos Inativos. \n\n" + ex.Message);
            }
        }




        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);



            CarregarAgendamento();
        }

        private void btnSobre_Click_1(object sender, EventArgs e)
        {
            new frmSobre().Show();
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

        private void btnSobre_Click(object sender, EventArgs e)
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked == true && radTodos.Checked == true)
            {
                CarregarUsuario();
                Variaveis.relatorio = "Clientes";
            }
            if (radCliente.Checked == true && radAtivo.Checked == true)
            {
                CarregarUsuarioAtivo();
                Variaveis.relatorio = "Cliente Ativo";
            }
            else if (radCliente.Checked == true && radInativo.Checked == true)
            {
                CarregarUsuarioInativo();
                Variaveis.relatorio = "Cliente Inativo";
            }
            else if (radReserva.Checked == true && radTodos.Checked == true)
            {
                CarregarAgendamento();
                Variaveis.relatorio = "Reservas";
            }
            else if (radReserva.Checked == true && radAtivo.Checked == true)
            {
                CarregarAgendamentoAtivo();
                Variaveis.relatorio = "Reserva Ativa";
            }
            else if (radReserva.Checked == true && radInativo.Checked == true)
            {
                CarregarAgendamentoInativo();
                Variaveis.relatorio = "Reserva Inativa";
            }
            else if (radFuncionario.Checked == true && radTodos.Checked == true)
            {
                CarregarFuncionario();
                Variaveis.relatorio = "Funcionários";
            }
            else if (radFuncionario.Checked == true && radAtivo.Checked == true)
            {
                CarregarFuncionarioAtivo();
                Variaveis.relatorio = "Funcionário Ativo";
            }
            else if (radFuncionario.Checked == true && radInativo.Checked == true)
            {
                CarregarFuncionarioInativo();
                Variaveis.relatorio = "Funcionário Ativo";
            }
            else
            {
                //MessageBox.Show("Selecione uma tabela e um filtro antes de atualizar");
            }
        }
    }
}
