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
    public partial class frmAgendamento : Form
    {

        private void CarregarAgendamento()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM reservacompleta ORDER BY STATUS = 'INATIVO'";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReserva.DataSource = dt;

                dgvReserva.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Agendamentos. \n\n" + ex.Message);
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

                dgvReserva.DataSource = dt;

                dgvReserva.ClearSelection();

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

                dgvReserva.DataSource = dt;

                dgvReserva.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Agendamentos Inativos. \n\n" + ex.Message);
            }
        }


        private void ExcluirReserva()
        {
            try
            {
                Banco.Conectar();
                string excluir = "DELETE FROM `reserva` WHERE idReserva = @codReserva";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codReserva", Variaveis.codReserva);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva excluída com sucesso!");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Reserva. \n\n" + ex.Message);
            }
        }



        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            pnlAgendamento.Location = new Point(this.Width / 2 - pnlAgendamento.Width / 2, this.Height / 2 - pnlAgendamento.Height / 2);

            CarregarAgendamento();
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadAgendar().Show();
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

        private void btnMenu_Click_2(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnCliente_Click_2(object sender, EventArgs e)
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

        
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarAgendamentoAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarAgendamentoInativo();
            }
            else
            {
                CarregarAgendamento();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaselecionada >= 0)
            {
                dgvReserva.Rows[Variaveis.linhaselecionada].Selected = true;
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirReserva();
                    new frmAgendamento().Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir");
            }
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaselecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaselecionada >= 0)
            {
                Variaveis.codReserva = Convert.ToInt32(dgvReserva[0, Variaveis.linhaselecionada].Value);
            }
        }

            private void txtAgendar_TextChanged(object sender, EventArgs e)
            {

            //DateTime dataReserva;
            //if (DateTime.TryParse(txtAgendar.Text, out dataReserva))
            //{
            //    Variaveis.dataReserva = dataReserva;

            //    cmbStatus.Enabled = false;
            //    cmbStatus.Text = "TODOS";
            //}
            //else
            //{
            //    cmbStatus.Enabled = true;
            //    cmbStatus.Text = "TODOS";
            //    CarregarAgendamentoNome();
            }
        }
    }
