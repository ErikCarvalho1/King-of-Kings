namespace KingOfKingsFrms
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            bntBuscar = new Button();
            bntAlterar = new Button();
            btnVoltar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            cmbTipo_usuario = new ComboBox();
            txtSenha = new TextBox();
            chkAtivo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSaida = new TextBox();
            txtEntrada = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnEmail, clnAtivo });
            dgvUsuarios.GridColor = Color.Black;
<<<<<<< HEAD
            dgvUsuarios.Location = new Point(132, 220);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(501, 363);
=======
            dgvUsuarios.Location = new Point(133, 233);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(502, 173);
>>>>>>> b5dd16715191cb6d73c6b375d87fa5cf0e914dec
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "Cpf";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(313, 191);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 23);
            bntBuscar.TabIndex = 1;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // bntAlterar
            // 
            bntAlterar.Location = new Point(217, 191);
            bntAlterar.Name = "bntAlterar";
            bntAlterar.Size = new Size(75, 24);
            bntAlterar.TabIndex = 2;
            bntAlterar.Text = "Alterar";
            bntAlterar.UseVisualStyleBackColor = true;
            bntAlterar.Click += bntAlterar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(408, 190);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 24);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnInserir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(207, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(39, 23);
            txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(252, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(136, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(207, 94);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(181, 23);
            txtCpf.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 7;
            // 
            // cmbTipo_usuario
            // 
            cmbTipo_usuario.FormattingEnabled = true;
            cmbTipo_usuario.Items.AddRange(new object[] { "Administrador", "Funcionário", "Cliente " });
            cmbTipo_usuario.Location = new Point(408, 65);
            cmbTipo_usuario.Name = "cmbTipo_usuario";
            cmbTipo_usuario.Size = new Size(136, 23);
            cmbTipo_usuario.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(207, 159);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(181, 23);
            txtSenha.TabIndex = 9;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.Black;
            chkAtivo.ForeColor = Color.FromArgb(219, 179, 91);
            chkAtivo.Location = new Point(415, 166);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = false;
            chkAtivo.CheckedChanged += chkAtivo_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(165, 68);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 11;
            label1.Text = "Id ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(252, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(165, 102);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 13;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(165, 131);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(165, 162);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Senha";
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(408, 131);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(136, 23);
            txtSaida.TabIndex = 16;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(408, 102);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(136, 23);
            txtEntrada.TabIndex = 17;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 418);
            Controls.Add(txtEntrada);
            Controls.Add(txtSaida);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkAtivo);
            Controls.Add(txtSenha);
            Controls.Add(cmbTipo_usuario);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnVoltar);
            Controls.Add(bntAlterar);
            Controls.Add(bntBuscar);
            Controls.Add(dgvUsuarios);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button bntBuscar;
        private Button bntAlterar;
        private Button btnVoltar;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private ComboBox cmbTipo_usuario;
        private TextBox txtSenha;
        private CheckBox chkAtivo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnAtivo;
        private TextBox txtSaida;
        private TextBox txtEntrada;
    }
}