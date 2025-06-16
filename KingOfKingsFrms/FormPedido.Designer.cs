namespace KingOfKingsFrms
{
    partial class FormPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            grbIndentificacao = new GroupBox();
            button1 = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtDescontoPedido = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            grbIndentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIndentificacao
            // 
            grbIndentificacao.BackColor = Color.Black;
            grbIndentificacao.Controls.Add(button1);
            grbIndentificacao.Controls.Add(btnInserePedido);
            grbIndentificacao.Controls.Add(txtIdCliente);
            grbIndentificacao.Controls.Add(textBox3);
            grbIndentificacao.Controls.Add(txtUsuario);
            grbIndentificacao.Controls.Add(label3);
            grbIndentificacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbIndentificacao.ForeColor = Color.FromArgb(219, 179, 91);
            grbIndentificacao.Location = new Point(32, 21);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(674, 152);
            grbIndentificacao.TabIndex = 0;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(219, 179, 91);
            button1.Location = new Point(34, 87);
            button1.Name = "button1";
            button1.Size = new Size(87, 40);
            button1.TabIndex = 3;
            button1.Text = "Cliente";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInserePedido
            // 
            btnInserePedido.BackgroundImage = (Image)resources.GetObject("btnInserePedido.BackgroundImage");
            btnInserePedido.FlatStyle = FlatStyle.Flat;
            btnInserePedido.ForeColor = Color.Black;
            btnInserePedido.Location = new Point(506, 44);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(103, 39);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = SystemColors.ActiveBorder;
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(127, 93);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(78, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(209, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ActiveBorder;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(92, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(372, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(34, 44);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.BackColor = Color.Black;
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(radioButton2);
            grbItens.Controls.Add(radioButton1);
            grbItens.Controls.Add(textBox1);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbItens.ForeColor = Color.FromArgb(219, 179, 91);
            grbItens.Location = new Point(32, 195);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(674, 333);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(472, 91);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 15;
            label4.Text = "R$ ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.ForeColor = Color.FromArgb(219, 179, 91);
            radioButton2.Location = new Point(455, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 21);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Real";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.FromArgb(219, 179, 91);
            radioButton1.Location = new Point(455, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 21);
            radioButton1.TabIndex = 14;
            radioButton1.Text = "Percentual";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(539, 288);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(122, 33);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(453, 291);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(219, 179, 91);
            label9.Location = new Point(472, 11);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(395, 46);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 10;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(325, 46);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(129, 46);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(11, 46);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.BackColor = SystemColors.ActiveBorder;
            txtDescontoItem.Location = new Point(455, 66);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(70, 25);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = SystemColors.ActiveBorder;
            txtQuantidade.Location = new Point(392, 66);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(53, 25);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.BackColor = SystemColors.ActiveBorder;
            txtValorUnit.Location = new Point(327, 66);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(59, 25);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.BackColor = SystemColors.ActiveBorder;
            txtCodBar.Location = new Point(13, 66);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(110, 25);
            txtCodBar.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.ActiveBorder;
            txtDescricao.Location = new Point(127, 66);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(195, 25);
            txtDescricao.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.BackgroundImage = (Image)resources.GetObject("btnAddItem.BackgroundImage");
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = Color.Black;
            btnAddItem.Location = new Point(539, 51);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(102, 41);
            btnAddItem.TabIndex = 5;
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.BackgroundColor = Color.Black;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.GridColor = Color.FromArgb(219, 179, 91);
            dgvItensPedido.Location = new Point(12, 111);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(649, 173);
            dgvItensPedido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(208, 34);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(709, 33);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 6;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.BackColor = SystemColors.ActiveBorder;
            txtIdPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(820, 30);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(181, 43);
            txtIdPedido.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ActiveBorder;
            txtTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(712, 450);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(274, 29);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "0,00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.ActiveBorder;
            txtSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(712, 276);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(274, 29);
            txtSubTotal.TabIndex = 6;
            txtSubTotal.Text = "0,00";
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.BackColor = SystemColors.ActiveBorder;
            txtDescontoItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescontoItens.Location = new Point(712, 339);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(274, 29);
            txtDescontoItens.TabIndex = 7;
            txtDescontoItens.Text = "0,00";
            txtDescontoItens.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(889, 481);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 42);
            btnFechar.TabIndex = 3;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.BackColor = SystemColors.ActiveBorder;
            txtDescontoPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescontoPedido.Location = new Point(712, 393);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(274, 29);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.Text = "0,00";
            txtDescontoPedido.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.ForeColor = Color.FromArgb(219, 179, 91);
            label11.Location = new Point(710, 257);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 9;
            label11.Text = "SubTotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.ForeColor = Color.FromArgb(219, 179, 91);
            label12.Location = new Point(710, 320);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 9;
            label12.Text = "Desconto Itens ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Black;
            label13.ForeColor = Color.FromArgb(219, 179, 91);
            label13.Location = new Point(712, 374);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 9;
            label13.Text = "Desconto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.ForeColor = Color.FromArgb(219, 179, 91);
            label14.Location = new Point(712, 431);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 9;
            label14.Text = "Total ";
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 45;
            // 
            // clnCodBar
            // 
            clnCodBar.FillWeight = 110F;
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 184;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(1005, 528);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIndentificacao);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(168, 147);
            Name = "FormPedido";
            Text = "FrmPedidoNovo";
            grbIndentificacao.ResumeLayout(false);
            grbIndentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIndentificacao;
        private GroupBox grbItens;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtUsuario;
        private TextBox textBox3;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox textBox1;
        private Label label10;
        private TextBox txtTotal;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtDescontoPedido;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label4;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}
       
