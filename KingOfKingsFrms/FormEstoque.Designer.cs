﻿namespace KingOfKingsFrms
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
            components = new System.ComponentModel.Container();
            dgvEstoque = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtNome = new TextBox();
            bntBuscar = new Button();
            bntAdicionar = new Button();
            bntEditar = new Button();
            produtoId = new TextBox();
            dateUltimoMovimento = new DateTimePicker();
            label6 = new Label();
            dd = new Label();
            label1 = new Label();
            label2 = new Label();
            txtquantidade = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = Color.Black;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEstoque.Location = new Point(191, 182);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(401, 217);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantidade";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Data ";
            Column4.Name = "Column4";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(137, 23);
            txtNome.TabIndex = 8;
            txtNome.TextChanged += txtBuscar_TextChanged;
            // 
            // bntBuscar
            // 
            bntBuscar.BackgroundImage = Properties.Resources.Buscar;
            bntBuscar.FlatStyle = FlatStyle.Flat;
            bntBuscar.ForeColor = SystemColors.ActiveCaptionText;
            bntBuscar.Location = new Point(427, 88);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(97, 35);
            bntBuscar.TabIndex = 9;
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // bntAdicionar
            // 
            bntAdicionar.Location = new Point(539, 136);
            bntAdicionar.Name = "bntAdicionar";
            bntAdicionar.Size = new Size(75, 23);
            bntAdicionar.TabIndex = 10;
            bntAdicionar.Text = "Adicionar";
            bntAdicionar.UseVisualStyleBackColor = true;
            bntAdicionar.Click += bntAdicionar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(539, 95);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 23);
            bntEditar.TabIndex = 11;
            bntEditar.Text = "Editar";
            bntEditar.UseVisualStyleBackColor = true;
            // 
            // produtoId
            // 
            produtoId.Enabled = false;
            produtoId.Location = new Point(64, 29);
            produtoId.Name = "produtoId";
            produtoId.Size = new Size(34, 23);
            produtoId.TabIndex = 12;
            produtoId.Visible = false;
            // 
            // dateUltimoMovimento
            // 
            dateUltimoMovimento.Location = new Point(173, 136);
            dateUltimoMovimento.Name = "dateUltimoMovimento";
            dateUltimoMovimento.Size = new Size(248, 23);
            dateUltimoMovimento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(329, 18);
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
            dd.Location = new Point(173, 75);
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
            label1.Location = new Point(329, 77);
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
            label2.Location = new Point(173, 118);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 49;
            label2.Text = "Ultimo movimento";
            // 
            // txtquantidade
            // 
            txtquantidade.Location = new Point(329, 95);
            txtquantidade.Name = "txtquantidade";
            txtquantidade.Size = new Size(92, 23);
            txtquantidade.TabIndex = 50;
            txtquantidade.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(438, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 51;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtquantidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dd);
            Controls.Add(label6);
            Controls.Add(dateUltimoMovimento);
            Controls.Add(produtoId);
            Controls.Add(bntEditar);
            Controls.Add(bntAdicionar);
            Controls.Add(bntBuscar);
            Controls.Add(txtNome);
            Controls.Add(dgvEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEstoque";
            Text = "FormEstoque";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstoque;
        private TextBox txtNome;
        private Button bntBuscar;
        private Button bntAdicionar;
        private Button bntEditar;
        private TextBox produtoId;
        private DateTimePicker dateUltimoMovimento;
        private Label label6;
        private Label dd;
        private Label label1;
        private Label label2;
        private TextBox txtquantidade;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}