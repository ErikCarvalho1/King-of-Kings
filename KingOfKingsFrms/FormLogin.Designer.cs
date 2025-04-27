namespace KingOfKingsFrms
{
    partial class FormLogin
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
            panel1 = new Panel();
            txtNomeUsuario = new TextBox();
            txtSenha = new TextBox();
            bntAcessar = new Button();
            bntCadastrar = new Button();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.kingLeaoLogin;
            panel1.Location = new Point(34, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 77);
            panel1.TabIndex = 0;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(157, 124);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(237, 23);
            txtNomeUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(157, 166);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 2;
            // 
            // bntAcessar
            // 
            bntAcessar.BackgroundImage = Properties.Resources.Acessar__3_;
            bntAcessar.FlatStyle = FlatStyle.Flat;
            bntAcessar.Location = new Point(166, 195);
            bntAcessar.Name = "bntAcessar";
            bntAcessar.Size = new Size(101, 38);
            bntAcessar.TabIndex = 3;
            bntAcessar.UseVisualStyleBackColor = true;
            bntAcessar.Click += bntAcessar_Click;
            // 
            // bntCadastrar
            // 
            bntCadastrar.BackgroundImage = Properties.Resources.CADASTRAR;
            bntCadastrar.FlatStyle = FlatStyle.Flat;
            bntCadastrar.Location = new Point(285, 195);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(100, 38);
            bntCadastrar.TabIndex = 4;
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.acesso2;
            panel2.Location = new Point(176, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 45);
            panel2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 0);
            linkLabel1.Location = new Point(475, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(26, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sair";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.usuario_login___1_;
            panel3.Location = new Point(127, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 30);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.usuario_senha;
            panel4.Location = new Point(129, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 29);
            panel4.TabIndex = 9;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 337);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Controls.Add(bntCadastrar);
            Controls.Add(bntAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeUsuario);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNomeUsuario;
        private TextBox txtSenha;
        private Button bntAcessar;
        private Button bntCadastrar;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Panel panel4;
    }
}