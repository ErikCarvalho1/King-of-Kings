namespace KingOfKingsFrms
{
    partial class FormCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            cmbTipo_usuario = new ComboBox();
            bntVoltar = new Button();
            bntCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            Tipo = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 150);
            txtId.Name = "txtId";
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 1;
            txtId.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(215, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(321, 150);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(138, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(215, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 23);
            txtEmail.TabIndex = 4;
            // 
            // cmbTipo_usuario
            // 
            cmbTipo_usuario.FormattingEnabled = true;
            cmbTipo_usuario.Items.AddRange(new object[] { "Administrador", "Funcionário", "Cliente" });
            cmbTipo_usuario.Location = new Point(465, 150);
            cmbTipo_usuario.Name = "cmbTipo_usuario";
            cmbTipo_usuario.Size = new Size(82, 23);
            cmbTipo_usuario.TabIndex = 5;
            cmbTipo_usuario.SelectedIndexChanged += cmbTipo_usuario_SelectedIndexChanged;
            // 
            // bntVoltar
            // 
            bntVoltar.BackgroundImage = Properties.Resources.bntVoltar;
            bntVoltar.FlatStyle = FlatStyle.Flat;
            bntVoltar.Location = new Point(215, 236);
            bntVoltar.Name = "bntVoltar";
            bntVoltar.Size = new Size(100, 36);
            bntVoltar.TabIndex = 7;
            bntVoltar.UseVisualStyleBackColor = true;
            bntVoltar.Click += bntVoltar_Click;
            // 
            // bntCadastrar
            // 
            bntCadastrar.BackColor = SystemColors.ActiveCaption;
            bntCadastrar.BackgroundImage = Properties.Resources.bntCadastrar;
            bntCadastrar.FlatStyle = FlatStyle.Flat;
            bntCadastrar.Location = new Point(445, 236);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(102, 33);
            bntCadastrar.TabIndex = 8;
            bntCadastrar.UseVisualStyleBackColor = false;
            bntCadastrar.Click += bntCadastrar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(240, 126);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(359, 126);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 10;
            label2.Text = "Cpf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(140, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(215, 207);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(332, 23);
            txtSenha.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(140, 205);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.BackColor = Color.Black;
            Tipo.FlatStyle = FlatStyle.Popup;
            Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tipo.ForeColor = Color.FromArgb(219, 179, 91);
            Tipo.Location = new Point(486, 126);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(44, 21);
            Tipo.TabIndex = 14;
            Tipo.Text = "Tipo";
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 418);
            Controls.Add(Tipo);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCadastrar);
            Controls.Add(bntVoltar);
            Controls.Add(cmbTipo_usuario);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            Load += FormCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private ComboBox cmbTipo_usuario;
        private Button bntVoltar;
        private Button bntCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private Label Tipo;
    }
}