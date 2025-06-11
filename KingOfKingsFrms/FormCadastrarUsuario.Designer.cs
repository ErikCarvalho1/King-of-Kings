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
            txtEmail = new TextBox();
            cmbNivel = new ComboBox();
            bntVoltar = new Button();
            bntCadastrar = new Button();
            label1 = new Label();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            Tipo = new Label();
            txtNome = new TextBox();
            dgvUsuarios = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            bntEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 1;
            txtId.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 23);
            txtEmail.TabIndex = 4;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Items.AddRange(new object[] { "Administrador", "Funcionário", "Cliente" });
            cmbNivel.Location = new Point(452, 120);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(82, 23);
            cmbNivel.TabIndex = 5;
            cmbNivel.SelectedIndexChanged += cmbTipo_usuario_SelectedIndexChanged;
            // 
            // bntVoltar
            // 
            bntVoltar.BackgroundImage = Properties.Resources.bntVoltar;
            bntVoltar.FlatStyle = FlatStyle.Flat;
            bntVoltar.Location = new Point(596, 448);
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
            bntCadastrar.Location = new Point(202, 206);
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
            label1.Location = new Point(227, 96);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(127, 154);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(202, 177);
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
            label4.Location = new Point(127, 175);
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
            Tipo.Location = new Point(473, 96);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(44, 21);
            Tipo.TabIndex = 14;
            Tipo.Text = "Tipo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(202, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(233, 23);
            txtNome.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnEmail, clnId, clnTipo });
            dgvUsuarios.Location = new Point(202, 283);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(344, 148);
            dgvUsuarios.TabIndex = 15;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.Visible = false;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.Name = "clnTipo";
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(310, 211);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 23);
            bntEditar.TabIndex = 16;
            bntEditar.Text = "Editar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // FormCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(774, 484);
            Controls.Add(bntEditar);
            Controls.Add(dgvUsuarios);
            Controls.Add(Tipo);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bntCadastrar);
            Controls.Add(bntVoltar);
            Controls.Add(cmbNivel);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarUsuario";
            Text = "FormCadastrar";
            Load += FormCadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private TextBox txtEmail;
        private ComboBox cmbNivel;
        private Button bntVoltar;
        private Button bntCadastrar;
        private Label label1;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private Label Tipo;
        private TextBox txtNome;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnTipo;
        private Button bntEditar;
    }
}