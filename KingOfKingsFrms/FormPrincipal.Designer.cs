namespace KingOfKingsFrms
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            bntHistorico = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.linha_dorada__2_;
            panel1.Location = new Point(78, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 10);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.linha_em_pe_dorada;
            panel2.Location = new Point(3, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 358);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.linha_em_pe_dorada;
            panel3.Location = new Point(789, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(71, 358);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.kingLeaoLogin;
            panel4.Location = new Point(39, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(83, 74);
            panel4.TabIndex = 5;
            // 
            // bntHistorico
            // 
            bntHistorico.BackgroundImage = Properties.Resources.historico__1_;
            bntHistorico.FlatStyle = FlatStyle.Popup;
            bntHistorico.Location = new Point(96, 25);
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
            button1.Location = new Point(164, 25);
            button1.Name = "button1";
            button1.Size = new Size(57, 41);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.kingofkings;
            ClientSize = new Size(999, 611);
            Controls.Add(button1);
            Controls.Add(bntHistorico);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button bntHistorico;
        private Button button1;
        private Panel panel5;
    }
}
