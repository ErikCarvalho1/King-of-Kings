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
            dataGridView1 = new DataGridView();
            cnlId = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnUtilmoMovimento = new DataGridViewTextBoxColumn();
            txtAdicionarEstoque = new NumericUpDown();
            txtBuscar = new TextBox();
            bntBuscar = new Button();
            bntAdicionar = new Button();
            bntEditar = new Button();
            txtId = new TextBox();
            dateUltimoMovimento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdicionarEstoque).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cnlId, clnQuantidade, clnUtilmoMovimento });
            dataGridView1.Location = new Point(96, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(304, 278);
            dataGridView1.TabIndex = 0;
            // 
            // cnlId
            // 
            cnlId.HeaderText = "ID";
            cnlId.Name = "cnlId";
            // 
            // clnQuantidade
            // 
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            // 
            // clnUtilmoMovimento
            // 
            clnUtilmoMovimento.HeaderText = "UltimoMovimento";
            clnUtilmoMovimento.Name = "clnUtilmoMovimento";
            // 
            // txtAdicionarEstoque
            // 
            txtAdicionarEstoque.Location = new Point(406, 145);
            txtAdicionarEstoque.Name = "txtAdicionarEstoque";
            txtAdicionarEstoque.Size = new Size(92, 23);
            txtAdicionarEstoque.TabIndex = 7;
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
            bntBuscar.Location = new Point(560, 104);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 23);
            bntBuscar.TabIndex = 9;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
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
            txtId.Location = new Point(52, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // dateUltimoMovimento
            // 
            dateUltimoMovimento.Location = new Point(406, 174);
            dateUltimoMovimento.Name = "dateUltimoMovimento";
            dateUltimoMovimento.Size = new Size(262, 23);
            dateUltimoMovimento.TabIndex = 13;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(dateUltimoMovimento);
            Controls.Add(txtId);
            Controls.Add(bntEditar);
            Controls.Add(bntAdicionar);
            Controls.Add(bntBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtAdicionarEstoque);
            Controls.Add(dataGridView1);
            Name = "FormEstoque";
            Text = "FormEstoque";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdicionarEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown txtAdicionarEstoque;
        private TextBox txtBuscar;
        private Button bntBuscar;
        private Button bntAdicionar;
        private Button bntEditar;
        private DataGridViewTextBoxColumn cnlId;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnUtilmoMovimento;
        private TextBox txtId;
        private DateTimePicker dateUltimoMovimento;
    }
}