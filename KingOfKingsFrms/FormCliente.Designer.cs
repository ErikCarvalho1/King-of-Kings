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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            Daodo = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            dateDataNascimento = new DateTimePicker();
            txtId = new TextBox();
            label8 = new Label();
            dgvClientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnCadastrar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            tabPage2 = new TabPage();
            maskCep = new MaskedTextBox();
            button4 = new Button();
            btninserir = new Button();
            cmbUF = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            cmbTipoendereco = new ComboBox();
            label12 = new Label();
            txtCidade = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Daodo.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Daodo
            // 
            Daodo.Controls.Add(tabPage1);
            Daodo.Controls.Add(tabPage2);
            Daodo.Location = new Point(12, 12);
            Daodo.Multiline = true;
            Daodo.Name = "Daodo";
            Daodo.SelectedIndex = 0;
            Daodo.Size = new Size(776, 416);
            Daodo.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.BackgroundImage = Properties.Resources.leaoFundo;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dateDataNascimento);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.EditarGbtn;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(623, 343);
            button2.Name = "button2";
            button2.Size = new Size(103, 38);
            button2.TabIndex = 66;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.bntVoltar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(41, 346);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 65;
            button1.UseVisualStyleBackColor = true;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Location = new Point(440, 109);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(173, 23);
            dateDataNascimento.TabIndex = 64;
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 63;
            txtId.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(141, 48);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 62;
            label8.Text = "Nome";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = Color.Black;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { nome, Column3, Column1, Cpf, Column2, Column4 });
            dgvClientes.GridColor = SystemColors.InactiveCaptionText;
            dgvClientes.Location = new Point(84, 183);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(602, 149);
            dgvClientes.TabIndex = 61;
            // 
            // nome
            // 
            nome.HeaderText = "Id";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Visible = false;
            nome.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nome";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 130;
            // 
            // Column1
            // 
            Column1.HeaderText = "Email";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 130;
            // 
            // Cpf
            // 
            Cpf.HeaderText = "Cpf";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telefone";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Data de nascimento";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 140;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = Properties.Resources.bntCadastrar;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(518, 343);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(99, 44);
            btnCadastrar.TabIndex = 60;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(217, 14);
            label6.Name = "label6";
            label6.Size = new Size(323, 34);
            label6.TabIndex = 59;
            label6.Text = "Cadastrar  Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(443, 93);
            label5.Name = "label5";
            label5.Size = new Size(127, 16);
            label5.TabIndex = 58;
            label5.Text = "Data de nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(443, 48);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 57;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Cursor = Cursors.SizeNWSE;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label3.Location = new Point(141, 138);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 56;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(141, 93);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 55;
            label2.Text = "Cpf";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(440, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 54;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(138, 154);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(174, 23);
            txtTelefone.TabIndex = 53;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(138, 109);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(174, 23);
            txtCpf.TabIndex = 52;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 51;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.leaoFundo;
            tabPage2.Controls.Add(maskCep);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(btninserir);
            tabPage2.Controls.Add(cmbUF);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(cmbTipoendereco);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // maskCep
            // 
            maskCep.Location = new Point(155, 73);
            maskCep.Mask = "00000-000";
            maskCep.Name = "maskCep";
            maskCep.Size = new Size(91, 23);
            maskCep.TabIndex = 64;
            maskCep.MaskInputRejected += maskCep_MaskInputRejected;
            // 
            // button4
            // 
            button4.Location = new Point(544, 205);
            button4.Name = "button4";
            button4.Size = new Size(76, 20);
            button4.TabIndex = 63;
            button4.UseVisualStyleBackColor = true;
            // 
            // btninserir
            // 
            btninserir.BackgroundImage = Properties.Resources.SalvarGbtn;
            btninserir.FlatStyle = FlatStyle.Flat;
            btninserir.Location = new Point(435, 197);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(103, 43);
            btninserir.TabIndex = 62;
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC", "AL", "AP ", "AM", "BA ", "CE ", "DF ", "ES ", "GO", "MA ", "MT ", "MS ", "MG ", "PA", "PB", "PR", "PE", "PI ", "RJ", "RN ", "RS ", "RO ", "RR ", "SC", "SP", "SE", "TO" });
            cmbUF.Location = new Point(561, 161);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(46, 23);
            cmbUF.TabIndex = 61;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(219, 179, 91);
            label14.Location = new Point(304, 42);
            label14.Name = "label14";
            label14.Size = new Size(167, 34);
            label14.TabIndex = 60;
            label14.Text = "ENDEREÇO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(219, 179, 91);
            label13.Location = new Point(155, 276);
            label13.Name = "label13";
            label13.Size = new Size(83, 15);
            label13.TabIndex = 14;
            label13.Text = "Tipo endereço";
            // 
            // cmbTipoendereco
            // 
            cmbTipoendereco.FormattingEnabled = true;
            cmbTipoendereco.Items.AddRange(new object[] { "RESIDENCIAL", "COMERCIAL" });
            cmbTipoendereco.Location = new Point(155, 294);
            cmbTipoendereco.Name = "cmbTipoendereco";
            cmbTipoendereco.Size = new Size(136, 23);
            cmbTipoendereco.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(219, 179, 91);
            label12.Location = new Point(435, 143);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 12;
            label12.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(435, 161);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(120, 23);
            txtCidade.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(219, 179, 91);
            label11.Location = new Point(435, 99);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 10;
            label11.Text = "Número";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(219, 179, 91);
            label10.Location = new Point(156, 231);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 9;
            label10.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(219, 179, 91);
            label9.Location = new Point(156, 187);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(156, 143);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(156, 99);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(156, 249);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(261, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(156, 205);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(261, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(156, 161);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(261, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(435, 117);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(156, 117);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(261, 23);
            txtCep.TabIndex = 0;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(Daodo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            Daodo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TabControl Daodo;
        private TabPage tabPage1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateDataNascimento;
        private TextBox txtId;
        private Label label8;
        private DataGridView dgvClientes;
        private Button btnCadastrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TabPage tabPage2;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtCep;
        private Label label1;
        private Label label7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label13;
        private ComboBox cmbTipoendereco;
        private Label label12;
        private TextBox txtCidade;
        private Label label14;
        private ComboBox cmbUF;
        private Button btninserir;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private MaskedTextBox maskCep;
    }
}