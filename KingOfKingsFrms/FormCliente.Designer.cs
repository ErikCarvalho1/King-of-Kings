namespace KingOfKingsFrms
{
    partial class FormCliente
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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvClientes = new DataGridView();
            label8 = new Label();
            btnCadastrar = new Button();
            txtId = new TextBox();
            dateDataNascimento = new DateTimePicker();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button1 = new Button();
            button2 = new Button();
            nome = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(140, 134);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(174, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(140, 184);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(174, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(441, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(140, 110);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 7;
            label2.Text = "Cpf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Cursor = Cursors.SizeNWSE;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label3.Location = new Point(140, 160);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 8;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(441, 60);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(441, 110);
            label5.Name = "label5";
            label5.Size = new Size(162, 21);
            label5.TabIndex = 10;
            label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(298, 19);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 11;
            label6.Text = "Cadastrar  Cliente";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { nome, Column3, Column1, Column2, Column4 });
            dgvClientes.Location = new Point(12, 224);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(764, 149);
            dgvClientes.TabIndex = 14;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(140, 60);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 46;
            label8.Text = "Nome";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = Properties.Resources.bntCadastrar;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(541, 376);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(99, 44);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(66, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 47;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Location = new Point(442, 134);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(173, 23);
            dateDataNascimento.TabIndex = 48;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.bntVoltar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 382);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 49;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.EditarGbtn;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(646, 376);
            button2.Name = "button2";
            button2.Size = new Size(103, 38);
            button2.TabIndex = 50;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nome
            // 
            nome.HeaderText = "Id";
            nome.Name = "nome";
            nome.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nome";
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column1
            // 
            Column1.HeaderText = "Email";
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telefone";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Data de nascimento";
            Column4.Name = "Column4";
            Column4.Width = 160;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateDataNascimento);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(dgvClientes);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvClientes;
        private Label label8;
        private Button btnCadastrar;
        private TextBox txtId;
        private DateTimePicker dateDataNascimento;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}