﻿namespace KingOfKingsFrms
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            bntHistorico = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            eddeToolStripMenuItem = new ToolStripMenuItem();
            bntCadastrar = new Button();
            pnlPrincipal = new Panel();
            bntUsuarios = new Button();
            panel6 = new Panel();
            bntSair = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.linha_dorada__2_;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(124, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 10);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.linha_dorada__2_;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 10);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.linha_em_pe_dorada;
            panel2.Location = new Point(45, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 433);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.linha_em_pe_dorada;
            panel3.Location = new Point(835, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(71, 355);
            panel3.TabIndex = 4;
            // 
            // bntHistorico
            // 
            bntHistorico.BackgroundImage = Properties.Resources.historico__1_;
            bntHistorico.FlatStyle = FlatStyle.Popup;
            bntHistorico.Location = new Point(124, 28);
            bntHistorico.Name = "bntHistorico";
            bntHistorico.Size = new Size(62, 41);
            bntHistorico.TabIndex = 6;
            bntHistorico.UseVisualStyleBackColor = true;
            bntHistorico.Click += bntHistorico_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Ajuda;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(192, 32);
            button1.Name = "button1";
            button1.Size = new Size(57, 41);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] { eddeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // eddeToolStripMenuItem
            // 
            eddeToolStripMenuItem.ForeColor = Color.FromArgb(219, 179, 91);
            eddeToolStripMenuItem.Name = "eddeToolStripMenuItem";
            eddeToolStripMenuItem.Size = new Size(66, 20);
            eddeToolStripMenuItem.Text = "Cadastro";
            eddeToolStripMenuItem.Click += eddeToolStripMenuItem_Click;
            // 
            // bntCadastrar
            // 
            bntCadastrar.Location = new Point(696, 41);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(75, 23);
            bntCadastrar.TabIndex = 9;
            bntCadastrar.Text = "cadastrar";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += bntCadastrar_Click;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackgroundImage = (Image)resources.GetObject("pnlPrincipal.BackgroundImage");
            pnlPrincipal.Location = new Point(124, 98);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(753, 457);
            pnlPrincipal.TabIndex = 10;
            pnlPrincipal.Paint += panel6_Paint;
            // 
            // bntUsuarios
            // 
            bntUsuarios.Location = new Point(615, 41);
            bntUsuarios.Name = "bntUsuarios";
            bntUsuarios.Size = new Size(75, 23);
            bntUsuarios.TabIndex = 11;
            bntUsuarios.Text = "Usuarios";
            bntUsuarios.UseVisualStyleBackColor = true;
            bntUsuarios.Click += bntUsuarios_Click;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.linha_dorada__2_;
            panel6.Location = new Point(405, 564);
            panel6.Name = "panel6";
            panel6.Size = new Size(458, 10);
            panel6.TabIndex = 3;
            // 
            // bntSair
            // 
            bntSair.Location = new Point(777, 41);
            bntSair.Name = "bntSair";
            bntSair.Size = new Size(75, 23);
            bntSair.TabIndex = 12;
            bntSair.Text = "Sair";
            bntSair.UseVisualStyleBackColor = true;
            bntSair.Click += bntSair_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(999, 611);
            Controls.Add(bntSair);
            Controls.Add(panel6);
            Controls.Add(bntUsuarios);
            Controls.Add(pnlPrincipal);
            Controls.Add(bntCadastrar);
            Controls.Add(button1);
            Controls.Add(bntHistorico);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = "Form1";
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button bntHistorico;
        private Button button1;
        private Panel panel5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eddeToolStripMenuItem;
        private Button bntCadastrar;
        private Panel pnlPrincipal;
        private Button bntUsuarios;
        private Panel panel4;
        private Panel panel6;
        private Button bntSair;
    }
}
