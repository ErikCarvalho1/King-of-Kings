namespace KingOfKingsFrms
{
    partial class FormProduto
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
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.linha_dorada__2_;
            panel4.Location = new Point(529, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 10);
            panel4.TabIndex = 4;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProduto";
            Text = "FormProduto";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
    }
}