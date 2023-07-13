namespace ProjetoTeste
{
    partial class frmCadAgendar
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
            this.pnlCadAgendar = new System.Windows.Forms.Panel();
            this.calReserva = new System.Windows.Forms.MonthCalendar();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirAgendar = new System.Windows.Forms.Button();
            this.btnCadastrarAgendar = new System.Windows.Forms.Button();
            this.pnlCadAgendar.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadAgendar
            // 
            this.pnlCadAgendar.BackColor = System.Drawing.Color.DimGray;
            this.pnlCadAgendar.BackgroundImage = global::ProjetoTeste.Properties.Resources.resto;
            this.pnlCadAgendar.Controls.Add(this.calReserva);
            this.pnlCadAgendar.Controls.Add(this.cmbUsuario);
            this.pnlCadAgendar.Controls.Add(this.lblUsuario);
            this.pnlCadAgendar.Controls.Add(this.lblStatus);
            this.pnlCadAgendar.Controls.Add(this.cmbStatus);
            this.pnlCadAgendar.Controls.Add(this.pnlCliente);
            this.pnlCadAgendar.Controls.Add(this.lblData);
            this.pnlCadAgendar.Controls.Add(this.lblNome);
            this.pnlCadAgendar.Controls.Add(this.txtCodigo);
            this.pnlCadAgendar.Controls.Add(this.label2);
            this.pnlCadAgendar.Controls.Add(this.btnExcluirAgendar);
            this.pnlCadAgendar.Controls.Add(this.btnCadastrarAgendar);
            this.pnlCadAgendar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadAgendar.Location = new System.Drawing.Point(40, 140);
            this.pnlCadAgendar.Name = "pnlCadAgendar";
            this.pnlCadAgendar.Size = new System.Drawing.Size(1200, 600);
            this.pnlCadAgendar.TabIndex = 8;
            this.pnlCadAgendar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadCliente_Paint);
            // 
            // calReserva
            // 
            this.calReserva.Location = new System.Drawing.Point(421, 218);
            this.calReserva.Name = "calReserva";
            this.calReserva.TabIndex = 115;
            this.calReserva.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calReserva_DateSelected);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(756, 215);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(177, 26);
            this.cmbUsuario.TabIndex = 114;
            this.cmbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(789, 174);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 24);
            this.lblUsuario.TabIndex = 109;
            this.lblUsuario.Text = "USUÁRIO";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(798, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 24);
            this.lblStatus.TabIndex = 107;
            this.lblStatus.Text = "STATUS";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(786, 350);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 26);
            this.cmbStatus.TabIndex = 106;
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCliente.BackgroundImage = global::ProjetoTeste.Properties.Resources.menu01;
            this.pnlCliente.Controls.Add(this.btnAjuda);
            this.pnlCliente.Controls.Add(this.pictureBox1);
            this.pnlCliente.Controls.Add(this.btnCliente);
            this.pnlCliente.Controls.Add(this.pictureBox3);
            this.pnlCliente.Controls.Add(this.btnSobre);
            this.pnlCliente.Controls.Add(this.pictureBox4);
            this.pnlCliente.Controls.Add(this.pictureBox2);
            this.pnlCliente.Controls.Add(this.btnSair);
            this.pnlCliente.Controls.Add(this.btnFuncionario);
            this.pnlCliente.Controls.Add(this.pictureBox5);
            this.pnlCliente.Controls.Add(this.pictureBox7);
            this.pnlCliente.Controls.Add(this.btnMenu);
            this.pnlCliente.Controls.Add(this.pictureBox6);
            this.pnlCliente.Controls.Add(this.btnAgendamento);
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(256, 600);
            this.pnlCliente.TabIndex = 102;
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::ProjetoTeste.Properties.Resources.book_of_black_cover_closed;
            this.pictureBox3.Location = new System.Drawing.Point(26, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionario.Location = new System.Drawing.Point(83, 191);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(173, 45);
            this.btnFuncionario.TabIndex = 61;
            this.btnFuncionario.Text = "FUNCIONÁRIO";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
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
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::ProjetoTeste.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(26, 191);
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
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.Color.White;
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.Color.Black;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 259);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(256, 45);
            this.btnAgendamento.TabIndex = 42;
            this.btnAgendamento.Text = "          AGENDAMENTO";
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(426, 169);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(202, 24);
            this.lblData.TabIndex = 101;
            this.lblData.Text = "DATA DA RESERVA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(478, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 24);
            this.lblNome.TabIndex = 84;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(350, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(94, 26);
            this.txtCodigo.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "CÓDIGO";
            // 
            // btnExcluirAgendar
            // 
            this.btnExcluirAgendar.BackColor = System.Drawing.Color.White;
            this.btnExcluirAgendar.FlatAppearance.BorderSize = 0;
            this.btnExcluirAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirAgendar.Location = new System.Drawing.Point(835, 526);
            this.btnExcluirAgendar.Name = "btnExcluirAgendar";
            this.btnExcluirAgendar.Size = new System.Drawing.Size(170, 45);
            this.btnExcluirAgendar.TabIndex = 56;
            this.btnExcluirAgendar.Text = "LIMPAR";
            this.btnExcluirAgendar.UseVisualStyleBackColor = false;
            this.btnExcluirAgendar.Click += new System.EventHandler(this.btnExcluirAgendar_Click);
            // 
            // btnCadastrarAgendar
            // 
            this.btnCadastrarAgendar.BackColor = System.Drawing.Color.White;
            this.btnCadastrarAgendar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarAgendar.Location = new System.Drawing.Point(430, 526);
            this.btnCadastrarAgendar.Name = "btnCadastrarAgendar";
            this.btnCadastrarAgendar.Size = new System.Drawing.Size(170, 45);
            this.btnCadastrarAgendar.TabIndex = 54;
            this.btnCadastrarAgendar.Text = "CADASTRAR";
            this.btnCadastrarAgendar.UseVisualStyleBackColor = false;
            this.btnCadastrarAgendar.Click += new System.EventHandler(this.btnCadastrarAgendar_Click);
            // 
            // frmCadAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ProjetoTeste.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 881);
            this.Controls.Add(this.pnlCadAgendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAgendar";
            this.Text = "CadAgendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadAgendar_Load);
            this.pnlCadAgendar.ResumeLayout(false);
            this.pnlCadAgendar.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadAgendar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnExcluirAgendar;
        private System.Windows.Forms.Button btnCadastrarAgendar;
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.MonthCalendar calReserva;
    }
}