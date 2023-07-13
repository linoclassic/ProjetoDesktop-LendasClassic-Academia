namespace ProjetoTeste
{
    partial class frmCadFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCadFuncionario = new System.Windows.Forms.Panel();
            this.mskdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskdCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.txtTpUsuario = new System.Windows.Forms.TextBox();
            this.lblTpUsuario = new System.Windows.Forms.Label();
            this.pnlCadFuncionario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadFuncionario
            // 
            this.pnlCadFuncionario.BackColor = System.Drawing.Color.DimGray;
            this.pnlCadFuncionario.BackgroundImage = global::ProjetoTeste.Properties.Resources.resto;
            this.pnlCadFuncionario.Controls.Add(this.mskdTelefone);
            this.pnlCadFuncionario.Controls.Add(this.lblTelefone);
            this.pnlCadFuncionario.Controls.Add(this.mskdCpf);
            this.pnlCadFuncionario.Controls.Add(this.lblStatus);
            this.pnlCadFuncionario.Controls.Add(this.cmbStatus);
            this.pnlCadFuncionario.Controls.Add(this.pnlCliente);
            this.pnlCadFuncionario.Controls.Add(this.lblCpf);
            this.pnlCadFuncionario.Controls.Add(this.txtSenha);
            this.pnlCadFuncionario.Controls.Add(this.lblSenha);
            this.pnlCadFuncionario.Controls.Add(this.txtEmail);
            this.pnlCadFuncionario.Controls.Add(this.lblEmail);
            this.pnlCadFuncionario.Controls.Add(this.txtNome);
            this.pnlCadFuncionario.Controls.Add(this.lblNome);
            this.pnlCadFuncionario.Controls.Add(this.txtCodigo);
            this.pnlCadFuncionario.Controls.Add(this.lblCodigo);
            this.pnlCadFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.txtTpUsuario);
            this.pnlCadFuncionario.Controls.Add(this.lblTpUsuario);
            this.pnlCadFuncionario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadFuncionario.Location = new System.Drawing.Point(36, 149);
            this.pnlCadFuncionario.Name = "pnlCadFuncionario";
            this.pnlCadFuncionario.Size = new System.Drawing.Size(1200, 600);
            this.pnlCadFuncionario.TabIndex = 8;
            // 
            // mskdTelefone
            // 
            this.mskdTelefone.Location = new System.Drawing.Point(687, 401);
            this.mskdTelefone.Mask = "(99) 00000-0000";
            this.mskdTelefone.Name = "mskdTelefone";
            this.mskdTelefone.Size = new System.Drawing.Size(206, 31);
            this.mskdTelefone.TabIndex = 106;
            this.mskdTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdTelefone_KeyPress_1);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(567, 405);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(118, 23);
            this.lblTelefone.TabIndex = 105;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // mskdCpf
            // 
            this.mskdCpf.Location = new System.Drawing.Point(657, 263);
            this.mskdCpf.Mask = "000.000.000-00";
            this.mskdCpf.Name = "mskdCpf";
            this.mskdCpf.Size = new System.Drawing.Size(187, 31);
            this.mskdCpf.TabIndex = 103;
            this.mskdCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdCpf_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(591, 336);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 23);
            this.lblStatus.TabIndex = 100;
            this.lblStatus.Text = "STATUS";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(687, 335);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(176, 26);
            this.cmbStatus.TabIndex = 99;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress_1);
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCliente.BackgroundImage = global::ProjetoTeste.Properties.Resources.menu01;
            this.pnlCliente.Controls.Add(this.pictureBox3);
            this.pnlCliente.Controls.Add(this.btnAjuda);
            this.pnlCliente.Controls.Add(this.pictureBox1);
            this.pnlCliente.Controls.Add(this.btnAgendamento);
            this.pnlCliente.Controls.Add(this.btnCliente);
            this.pnlCliente.Controls.Add(this.btnSobre);
            this.pnlCliente.Controls.Add(this.pictureBox4);
            this.pnlCliente.Controls.Add(this.pictureBox2);
            this.pnlCliente.Controls.Add(this.btnSair);
            this.pnlCliente.Controls.Add(this.pictureBox5);
            this.pnlCliente.Controls.Add(this.pictureBox7);
            this.pnlCliente.Controls.Add(this.btnMenu);
            this.pnlCliente.Controls.Add(this.pictureBox6);
            this.pnlCliente.Controls.Add(this.btnFuncionario);
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(253, 600);
            this.pnlCliente.TabIndex = 98;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjetoTeste.Properties.Resources.book_of_black_cover_closed;
            this.pictureBox3.Location = new System.Drawing.Point(23, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.Black;
            this.btnAjuda.Location = new System.Drawing.Point(83, 410);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(173, 45);
            this.btnAjuda.TabIndex = 58;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoTeste.Properties.Resources.hand;
            this.pictureBox1.Location = new System.Drawing.Point(26, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.Color.Black;
            this.btnAgendamento.Location = new System.Drawing.Point(72, 263);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(191, 45);
            this.btnAgendamento.TabIndex = 42;
            this.btnAgendamento.Text = "AGENDAMENTO";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Location = new System.Drawing.Point(83, 117);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(173, 45);
            this.btnCliente.TabIndex = 63;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.Black;
            this.btnSobre.Location = new System.Drawing.Point(83, 335);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(173, 45);
            this.btnSobre.TabIndex = 66;
            this.btnSobre.Text = "SOBRE";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ProjetoTeste.Properties.Resources.cross_mark_on_a_black_circle_background;
            this.pictureBox4.Location = new System.Drawing.Point(26, 509);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjetoTeste.Properties.Resources.group;
            this.pictureBox2.Location = new System.Drawing.Point(26, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(107, 522);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 45);
            this.btnSair.TabIndex = 53;
            this.btnSair.Text = "SAÍDA";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ProjetoTeste.Properties.Resources.list;
            this.pictureBox5.Location = new System.Drawing.Point(26, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::ProjetoTeste.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(26, 193);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 60;
            this.pictureBox7.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(83, 53);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(173, 45);
            this.btnMenu.TabIndex = 57;
            this.btnMenu.Text = "MENU";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ProjetoTeste.Properties.Resources.question_mark_on_a_circular_black_background;
            this.pictureBox6.Location = new System.Drawing.Point(26, 414);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 59;
            this.pictureBox6.TabStop = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.White;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 191);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(256, 45);
            this.btnFuncionario.TabIndex = 61;
            this.btnFuncionario.Text = "         FUNCIONÁRIO";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.SystemColors.Control;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(605, 267);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(50, 23);
            this.lblCpf.TabIndex = 97;
            this.lblCpf.Text = "CPF";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(657, 203);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(213, 27);
            this.txtSenha.TabIndex = 89;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress_1);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(571, 205);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(84, 23);
            this.lblSenha.TabIndex = 88;
            this.lblSenha.Text = "SENHA";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(473, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(584, 27);
            this.txtEmail.TabIndex = 87;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(393, 137);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 23);
            this.lblEmail.TabIndex = 86;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(473, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(584, 27);
            this.txtNome.TabIndex = 85;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress_1);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(398, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 23);
            this.lblNome.TabIndex = 84;
            this.lblNome.Text = "NOME";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(368, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 83;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(271, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 23);
            this.lblCodigo.TabIndex = 82;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(855, 526);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(170, 45);
            this.btnExcluirFuncionario.TabIndex = 56;
            this.btnExcluirFuncionario.Text = "LIMPAR";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(418, 526);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(170, 45);
            this.btnCadastrarFuncionario.TabIndex = 54;
            this.btnCadastrarFuncionario.Text = "CADASTRAR";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            this.btnCadastrarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCadastrarFuncionario_KeyPress);
            // 
            // txtTpUsuario
            // 
            this.txtTpUsuario.Enabled = false;
            this.txtTpUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTpUsuario.Location = new System.Drawing.Point(1153, 15);
            this.txtTpUsuario.Name = "txtTpUsuario";
            this.txtTpUsuario.Size = new System.Drawing.Size(35, 27);
            this.txtTpUsuario.TabIndex = 104;
            this.txtTpUsuario.Text = "1";
            // 
            // lblTpUsuario
            // 
            this.lblTpUsuario.AutoSize = true;
            this.lblTpUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblTpUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpUsuario.Location = new System.Drawing.Point(946, 17);
            this.lblTpUsuario.Name = "lblTpUsuario";
            this.lblTpUsuario.Size = new System.Drawing.Size(206, 23);
            this.lblTpUsuario.TabIndex = 102;
            this.lblTpUsuario.Text = "TIPO DE USUÁRIO";
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ProjetoTeste.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 898);
            this.Controls.Add(this.pnlCadFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.pnlCadFuncionario.ResumeLayout(false);
            this.pnlCadFuncionario.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadFuncionario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Label lblTpUsuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mskdCpf;
        private System.Windows.Forms.MaskedTextBox mskdTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTpUsuario;
    }
}