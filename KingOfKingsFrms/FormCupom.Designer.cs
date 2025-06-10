namespace KingOfKingsFrms
{
    partial class FormCupom
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(289, 43);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 0;
            label1.Text = "Cupom de Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(55, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(55, 194);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Desconto ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(55, 257);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantida disponivel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(336, 257);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Data limite";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.FromArgb(219, 179, 91);
            checkBox1.Location = new Point(55, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(221, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Cupom válido para todas as entradas";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 6;
            // 
            // FormCupom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCupom";
            Text = "Cupom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private TextBox textBox1;
    }
}