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
            dataGridView1 = new DataGridView();
            tabItemPedido = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            grbIndentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabItemPedido.SuspendLayout();
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
            grbIndentificacao.Location = new Point(687, 35);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(313, 220);
            grbIndentificacao.TabIndex = 0;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(219, 179, 91);
            button1.Location = new Point(7, 64);
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
            btnInserePedido.Location = new Point(204, 113);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(103, 39);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = SystemColors.ActiveBorder;
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(100, 71);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(56, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(162, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ActiveBorder;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(70, 21);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(239, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(7, 25);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(192, 33);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(708, 6);
            label2.Name = "label2";
            label2.Size = new Size(106, 29);
            label2.TabIndex = 6;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.BackColor = SystemColors.ActiveBorder;
            txtIdPedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(819, 3);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(181, 35);
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
            btnFechar.Click += btnFechar_Click;
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
            label11.Size = new Size(52, 15);
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
            label14.Size = new Size(35, 15);
            label14.TabIndex = 9;
            label14.Text = "Total ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 223);
            dataGridView1.TabIndex = 10;
            // 
            // tabItemPedido
            // 
            tabItemPedido.Controls.Add(tabPage1);
            tabItemPedido.Controls.Add(tabPage2);
            tabItemPedido.Location = new Point(12, 276);
            tabItemPedido.Name = "tabItemPedido";
            tabItemPedido.SelectedIndex = 0;
            tabItemPedido.Size = new Size(670, 247);
            tabItemPedido.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.ForeColor = Color.FromArgb(219, 179, 91);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(662, 219);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Itens do Pedido";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(662, 219);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Observação";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(1005, 528);
            Controls.Add(label1);
            Controls.Add(tabItemPedido);
            Controls.Add(dataGridView1);
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
            Controls.Add(grbIndentificacao);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(168, 147);
            Name = "FormPedido";
            Text = "FrmPedidoNovo";
            grbIndentificacao.ResumeLayout(false);
            grbIndentificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabItemPedido.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIndentificacao;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtUsuario;
        private TextBox textBox3;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private TextBox txtTotal;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtDescontoPedido;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button1;
        private DataGridView dataGridView1;
        private TabControl tabItemPedido;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
       
