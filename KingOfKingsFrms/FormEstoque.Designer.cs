namespace KingOfKingsFrms
{
    partial class FormEstoque
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
            dgvEstoque = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtAdicionarEstoque = new NumericUpDown();
            txtBuscar = new TextBox();
            bntBuscar = new Button();
            bntAdicionar = new Button();
            bntEditar = new Button();
            txtId = new TextBox();
            dateUltimoMovimento = new DateTimePicker();
            label6 = new Label();
            dd = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdicionarEstoque).BeginInit();
            SuspendLayout();
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = Color.Black;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvEstoque.Location = new Point(84, 104);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(304, 278);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantidade";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Data ";
            Column3.Name = "Column3";
            // 
            // txtAdicionarEstoque
            // 
            txtAdicionarEstoque.Location = new Point(406, 145);
            txtAdicionarEstoque.Name = "txtAdicionarEstoque";
            txtAdicionarEstoque.Size = new Size(92, 23);
            txtAdicionarEstoque.TabIndex = 7;
            txtAdicionarEstoque.ValueChanged += txtAdicionarEstoque_ValueChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(406, 104);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(137, 23);
            txtBuscar.TabIndex = 8;
            // 
            // bntBuscar
            // 
            bntBuscar.BackgroundImage = Properties.Resources.Buscar;
            bntBuscar.FlatStyle = FlatStyle.Flat;
            bntBuscar.ForeColor = SystemColors.ActiveCaptionText;
            bntBuscar.Location = new Point(549, 92);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(97, 35);
            bntBuscar.TabIndex = 9;
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // bntAdicionar
            // 
            bntAdicionar.Location = new Point(504, 145);
            bntAdicionar.Name = "bntAdicionar";
            bntAdicionar.Size = new Size(75, 23);
            bntAdicionar.TabIndex = 10;
            bntAdicionar.Text = "Adicionar";
            bntAdicionar.UseVisualStyleBackColor = true;
            bntAdicionar.Click += bntAdicionar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(585, 145);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 23);
            bntEditar.TabIndex = 11;
            bntEditar.Text = "Editar";
            bntEditar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // dateUltimoMovimento
            // 
            dateUltimoMovimento.Location = new Point(406, 189);
            dateUltimoMovimento.Name = "dateUltimoMovimento";
            dateUltimoMovimento.Size = new Size(262, 23);
            dateUltimoMovimento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(232, 19);
            label6.Name = "label6";
            label6.Size = new Size(146, 34);
            label6.TabIndex = 46;
            label6.Text = "Estoque";
            // 
            // dd
            // 
            dd.AutoSize = true;
            dd.BackColor = SystemColors.ActiveCaptionText;
            dd.ForeColor = Color.FromArgb(219, 179, 91);
            dd.Location = new Point(406, 86);
            dd.Name = "dd";
            dd.Size = new Size(40, 15);
            dd.TabIndex = 47;
            dd.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(406, 130);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 48;
            label1.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(406, 171);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 49;
            label2.Text = "Ultimo movimento";
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dd);
            Controls.Add(label6);
            Controls.Add(dateUltimoMovimento);
            Controls.Add(txtId);
            Controls.Add(bntEditar);
            Controls.Add(bntAdicionar);
            Controls.Add(bntBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtAdicionarEstoque);
            Controls.Add(dgvEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEstoque";
            Text = "FormEstoque";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdicionarEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstoque;
        private NumericUpDown txtAdicionarEstoque;
        private TextBox txtBuscar;
        private Button bntBuscar;
        private Button bntAdicionar;
        private Button bntEditar;
        private TextBox txtId;
        private DateTimePicker dateUltimoMovimento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label6;
        private Label dd;
        private Label label1;
        private Label label2;
    }
}