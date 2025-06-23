namespace KingOfKingsFrms
{
    partial class FormListarProduto
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
            dgvProduto = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtProdutos = new TextBox();
            Produtos = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvProduto.Location = new Point(144, 144);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersVisible = false;
            dgvProduto.Size = new Size(612, 304);
            dgvProduto.TabIndex = 0;
            dgvProduto.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codbarras";
            Column2.Name = "Column2";
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor unitario";
            Column4.Name = "Column4";
            Column4.Width = 160;
            // 
            // txtProdutos
            // 
            txtProdutos.Location = new Point(224, 108);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(311, 23);
            txtProdutos.TabIndex = 2;
            txtProdutos.TextChanged += txtProdutos_TextChanged;
            // 
            // Produtos
            // 
            Produtos.AutoSize = true;
            Produtos.BackColor = Color.Black;
            Produtos.ForeColor = Color.FromArgb(219, 179, 91);
            Produtos.Location = new Point(224, 90);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(55, 15);
            Produtos.TabIndex = 3;
            Produtos.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(296, 27);
            label2.Name = "label2";
            label2.Size = new Size(280, 34);
            label2.TabIndex = 18;
            label2.Text = "Listar Produtos";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Buscar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(541, 98);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            // 
            // FormListarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(887, 517);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Produtos);
            Controls.Add(txtProdutos);
            Controls.Add(dgvProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListarProduto";
            Text = "FormProduto";
            Load += FormListarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduto;
        private TextBox txtProdutos;
        private Label Produtos;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}