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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoTeste
{
    public partial class frmCadCliente : Form
    {

        int codigo;
        private void AlterarUsuario()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE `usuario` SET `nomeUsuario`=@nomeUsuario,`fkTpUsuario`=@fkTpUsuario,`statusUsuario`=@statusUsuario,`emailUsuario`=@emailUsuario,`senhaUsuario`=@senhaUsuario,`cpfUsuario`=@cpfUsuario,`telefoneUsuario`=@telefoneUsuario WHERE idUsuario = @codUsuario";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeUsuario", Variaveis.nomeUsuario);
                cmd.Parameters.AddWithValue("@fkTpUsuario", Variaveis.fkTpUsuario);
                cmd.Parameters.AddWithValue("@statusUsuario", Variaveis.statusUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", Variaveis.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", Variaveis.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", Variaveis.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", Variaveis.telefoneUsuario);
                cmd.Parameters.AddWithValue("@codUsuario", Variaveis.codUsuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO CLIENTE REALIZADO COM SUCESSO", "ALTERAÇÃO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA ALTERAÇÃO DO CLIENTE \n\n" + ex);
            }
        }




        private void InserirUsuario()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO `usuario`(`idUsuario`, `nomeUsuario`, `fkTpUsuario`, `statusUsuario`, `emailUsuario`, `senhaUsuario`, `cpfUsuario`, `telefoneUsuario`) VALUES (DEFAULT,@nomeUsuario,@fkTpUsuario,@statusUsuario,@emailUsuario,@senhaUsuario,@cpfUsuario,@telefoneUsuario)";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nomeUsuario", Variaveis.nomeUsuario);
                cmd.Parameters.AddWithValue("@fkTpUsuario", Variaveis.fkTpUsuario);
                cmd.Parameters.AddWithValue("@statusUsuario", Variaveis.statusUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", Variaveis.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", Variaveis.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", Variaveis.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", Variaveis.telefoneUsuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO CLIENTE REALIZADO COM SUCESSO", "CADASTRO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NO CADASTRO DO FUNCIONÁRIO \n\n" + ex);
            }
        }



        private void CarregarDadosUsuario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM `usuario` WHERE `idUsuario` =@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codUsuario);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codUsuario = dr.GetInt32(0);
                    Variaveis.nomeUsuario = dr.GetString(1);
                    Variaveis.fkTpUsuario = dr.GetString(2);
                    Variaveis.statusUsuario = dr.GetString(3);
                    Variaveis.emailUsuario = dr.GetString(4);
                    Variaveis.senhaUsuario = dr.GetString(5);
                    Variaveis.cpfUsuario = dr.GetString(6);
                    Variaveis.telefoneUsuario = dr.GetString(7);

                    txtCodigo.Text = Variaveis.codUsuario.ToString();
                    txtNomeCliente.Text = Variaveis.nomeUsuario;
                    cmbTipoUsuario.Text = Variaveis.fkTpUsuario;
                    cmbStatus.Text = Variaveis.statusUsuario;
                    txtEmail.Text = Variaveis.emailUsuario;
                    txtSenha.Text = Variaveis.senhaUsuario;
                    mskCpf.Text = Variaveis.cpfUsuario;
                    mskdTelefone.Text = Variaveis.telefoneUsuario;
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente. \n\n" + ex);
            }
        }





        private void CarregarUltimoUsuario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT MAX(idUsuario) FROM `usuario`"; MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codUsuario = dr.GetInt32(0);
                }

                Banco.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último Cliente. \n\n" + ex);
            }
        }

        public frmCadCliente()
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
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            if (Variaveis.funcao == "ALTERAR")
            {
                btnCadastrarCliente.Text = "EDITAR";
                CarregarDadosUsuario();
            }

            if (txtCodigo.Text != "")
            {

                btnCadastrarCliente.Enabled = true;
                mskdTelefone.Enabled = true;
                txtNomeCliente.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
                mskCpf.Enabled = true;
            }

            //CODIGO
            codigo = 1;
            txtCodigo.Text = codigo.ToString();
            txtNomeCliente.Focus();

            cmbStatus.Text = "ATIVO";
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNomeCliente.Focus();
            }


            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (mskdTelefone.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o Fone");
                mskdTelefone.Focus();
            }
            else if (mskCpf.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o CPF");
                mskCpf.Focus();
            }

            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else
            {
                Variaveis.nomeUsuario = txtNomeCliente.Text;
                Variaveis.fkTpUsuario = cmbTipoUsuario.Text;
                Variaveis.emailUsuario = txtEmail.Text;
                Variaveis.senhaUsuario = txtSenha.Text;
                Variaveis.telefoneUsuario = mskdTelefone.Text;
                Variaveis.cpfUsuario = mskCpf.Text;
                Variaveis.statusUsuario = cmbStatus.Text;

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirUsuario();
                    CarregarUltimoUsuario();
                    

                    new frmCliente().Show();
                    Hide();
                }

                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarUsuario();

                    new frmCliente().Show();
                    Close();
                }
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtSenha.Text = String.Empty;
            mskdTelefone.Text = String.Empty;
            mskCpf.Text = String.Empty;
            cmbStatus.Text = String.Empty;
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

        private void btnSair_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            AlterarUsuario();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mskCpf.Clear();
            mskdTelefone.Clear();

            txtNomeCliente.Focus();
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskCpf.Enabled = true;
                mskCpf.Focus();
            }
        }

        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskdTelefone.Enabled = true;
                mskdTelefone.Focus();
            }
        }

        

        private void mskdTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCadastrarCliente.Enabled = true;
                btnCadastrarCliente.Focus();
            }
        }

        private void btnCadastrarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLimpar.Enabled = true;
                btnLimpar.Focus();
            }
        }
    }
}
