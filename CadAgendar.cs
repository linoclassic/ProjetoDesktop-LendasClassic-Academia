using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class frmCadAgendar : Form
    {


        private void InserirReserva()
        {   
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO `reserva`(`idReserva`, `dataReserva`, `statusReserva`, `fkUsuario`) VALUES (DEFAULT,@dataReserva,@statusReserva,@codUsuario)";

                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@statusReserva", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codUsuario", Variaveis.codUsuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("AGENDAMENTO REALIZADO COM SUCESSO", "RESERVA");
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO NO AGENDAMENTO DO CLIENTE \n\n" + erro, "ERROR!");
            }
        }







        private void CarregarDadosReserva()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT `idReserva`, `dataReserva`, `statusReserva`, `nomeUsuario` FROM `reserva` INNER JOIN `usuario` ON `usuario`.`idUsuario` = `reserva`.`fkUsuario` WHERE `idReserva` = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.dataReserva = reader.GetDateTime(1);
                    Variaveis.statusReserva = reader.GetString(2);
                    Variaveis.nomeUsuario = reader.GetString(3);

                    txtCodigo.Text = Variaveis.codUsuario.ToString();
                    cmbStatus.Text = Variaveis.statusReserva;
                    calReserva.SelectionStart = Variaveis.dataReserva;
                    cmbUsuario.Text = Variaveis.nomeUsuario;
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da reserva. \n\n" + ex);
            }
        }





        private void CarregarUltimaReserva()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT MAX(idReserva) FROM `reserva`"; MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codReserva = dr.GetInt32(0);
                }

                Banco.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último Agendamento. \n\n" + ex);
            }
        }

        private void CarregarUsuarios()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT idUsuario, nomeUsuario FROM usuario WHERE fkTpUsuario = 2 and statusUsuario = 'ATIVO' AND idUsuario NOT IN (SELECT DISTINCT fkUsuario FROM reserva)\r\n";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUsuario.DataSource = dt;
                cmbUsuario.DisplayMember = "nomeUsuario";
                cmbUsuario.ValueMember = "idUsuario";
                cmbUsuario.SelectedIndex = -1;
                Banco.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Clientes.\n\n" + ex.Message);
            }
        }

        public frmCadAgendar()
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

        private void pnlCadCliente_Paint(object sender, PaintEventArgs e)
        {
            pnlCadAgendar.Location = new Point(this.Width / 2 - pnlCadAgendar.Width / 2, this.Height / 2 - pnlCadAgendar.Height / 2);
        }

        private void btnCadastrarAgendar_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher os Status");
                cmbStatus.Focus();
            }
            else if (cmbUsuario.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o Usuario");
                cmbUsuario.Focus();
            }
            else
            {
                Variaveis.statusReserva = cmbStatus.Text;
                Variaveis.dataReserva = calReserva.SelectionStart;
                Variaveis.nomeUsuario = cmbUsuario.Text;
                Variaveis.codUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirReserva();
                    CarregarUltimaReserva();

                    new frmAgendamento().Show();
                    Hide();
                }
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja mesmo Sair?", "Tela de Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmCadAgendar_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void calReserva_DateSelected(object sender, DateRangeEventArgs e)
        {
            Variaveis.dataReserva = calReserva.SelectionStart;
        }

        private void cmbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbUsuario.Enabled = true;
                cmbUsuario.Focus();
            }
        }

        private void btnExcluirAgendar_Click(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            calReserva.Focus();
        }
    }
}
