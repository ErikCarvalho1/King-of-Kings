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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            txtNomeUsuario = new TextBox();
            txtSenha = new TextBox();
            bntAcessar = new Button();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtNomeUsuario.Location = new Point(163, 124);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(237, 23);
            txtNomeUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(163, 166);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 2;
            // 
            // bntAcessar
            // 
            bntAcessar.BackColor = SystemColors.ActiveCaptionText;
            bntAcessar.BackgroundImage = Properties.Resources.bntAcessar;
            bntAcessar.Cursor = Cursors.Hand;
            bntAcessar.FlatStyle = FlatStyle.Flat;
            bntAcessar.Location = new Point(220, 195);
            bntAcessar.Name = "bntAcessar";
            bntAcessar.Size = new Size(100, 38);
            bntAcessar.TabIndex = 3;
            bntAcessar.UseVisualStyleBackColor = false;
            bntAcessar.Click += bntAcessar_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Login;
            panel2.Location = new Point(176, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 45);
            panel2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 0);
            linkLabel1.Location = new Point(494, 313);
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
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Location = new Point(129, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 29);
            panel4.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(21, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.ocultarSenha;
            pictureBox1.Location = new Point(397, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 337);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Controls.Add(bntAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            Load += FormLogin_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNomeUsuario;
        private TextBox txtSenha;
        private Button bntAcessar;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
    }
}