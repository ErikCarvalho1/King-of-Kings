namespace KingOfKingsFrms
{
    partial class FormCaixa
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
            label6 = new Label();
            dataGridView1 = new DataGridView();
            clnSaldo = new DataGridViewTextBoxColumn();
            clndataInicio = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(327, 65);
            label6.Name = "label6";
            label6.Size = new Size(102, 34);
            label6.TabIndex = 46;
            label6.Text = "Caixa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnSaldo, clndataInicio, clnStatus });
            dataGridView1.Location = new Point(228, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 237);
            dataGridView1.TabIndex = 47;
            // 
            // clnSaldo
            // 
            clnSaldo.HeaderText = "Saldo";
            clnSaldo.Name = "clnSaldo";
            // 
            // clndataInicio
            // 
            clndataInicio.HeaderText = "Data De abertura";
            clndataInicio.Name = "clndataInicio";
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            // 
            // FormCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "FormCaixa";
            Text = "FormCaixa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnSaldo;
        private DataGridViewTextBoxColumn clndataInicio;
        private DataGridViewTextBoxColumn clnStatus;
    }
}