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
    public partial class frmCadFuncionario : Form
    {

        private void AlterarFuncionario()
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
                MessageBox.Show("ALTERAÇÃO DO FUNCIONARIO REALIZADO COM SUCESSO", "ALTERAÇÃO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA ALTERAÇÃO DO FUNCIONARIO \n\n" + ex);
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
                MessageBox.Show("CADASTRO DO FUNCIONÁRIO REALIZADO COM SUCESSO", "CADASTRO");
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NO CADASTRO DO FUNCIONÁRIO \n\n" + ex);
            }
        }


        private void CarregarDadosFuncionario()
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
                    txtNome.Text = Variaveis.nomeUsuario;
                    txtTpUsuario.Text = Variaveis.fkTpUsuario;
                    cmbStatus.Text = Variaveis.statusUsuario;
                    txtEmail.Text = Variaveis.emailUsuario;
                    txtSenha.Text = Variaveis.senhaUsuario;
                    mskdCpf.Text = Variaveis.cpfUsuario;
                    mskdTelefone.Text = Variaveis.telefoneUsuario;
                }
                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Funcionario. \n\n" + ex);
            }
        }



        private void CarregarUltimoUsuario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT MAX(idUsuario) FROM `usuario`"; 
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.codUsuario = dr.GetInt32(0);
                }

                Banco.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar último Funcionário. \n\n" + ex);
            }
        }



        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);

            if (Variaveis.funcao == "ALTERAR")
            {
                btnCadastrarFuncionario.Text = "EDITAR";
                CarregarDadosFuncionario();
            }

            if (txtCodigo.Text != "")
            {

                btnCadastrarFuncionario.Enabled = true;
                mskdTelefone.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
                mskdCpf.Enabled = true;
            }
            txtNome.Focus();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNome.Focus();
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
            else if (mskdCpf.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o CPF");
                mskdCpf.Focus();
            }

            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else
            {
                Variaveis.nomeUsuario = txtNome.Text;
                Variaveis.fkTpUsuario = txtTpUsuario.Text;
                Variaveis.emailUsuario = txtEmail.Text;
                Variaveis.senhaUsuario = txtSenha.Text;
                Variaveis.telefoneUsuario = mskdTelefone.Text;
                Variaveis.cpfUsuario = mskdCpf.Text;
                Variaveis.statusUsuario = cmbStatus.Text;

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirUsuario();
                    CarregarUltimoUsuario();

                    new frmFuncionario().Show();
                    Close();

                }

                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarFuncionario();
                    new frmFuncionario().Show();
                    Close();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtSenha.Text = String.Empty;
            mskdTelefone.Text = String.Empty;
            mskdCpf.Text = String.Empty;
            cmbStatus.Text = String.Empty;
        }


        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskdCpf.Enabled = true;
                mskdCpf.Focus();
            }
        }

        private void mskdCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskdTelefone.Enabled = true;
                mskdTelefone.Focus();
            }
        }

        private void mskdTelefone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCadastrarFuncionario.Enabled = true;
                btnCadastrarFuncionario.Focus();
            }
        }

        private void btnCadastrarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnExcluirFuncionario.Enabled = true;
                btnExcluirFuncionario.Focus();
            }
        }
    }
}
