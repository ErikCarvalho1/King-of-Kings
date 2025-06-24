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
            NovoPedido = new GroupBox();
            label9 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ItemPedido = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            grbIndentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            NovoPedido.SuspendLayout();
            ItemPedido.SuspendLayout();
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
            grbIndentificacao.Location = new Point(687, 71);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(313, 184);
            grbIndentificacao.TabIndex = 0;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(219, 179, 91);
            button1.Location = new Point(6, 68);
            button1.Name = "button1";
            button1.Size = new Size(55, 33);
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
            txtIdCliente.Location = new Point(71, 71);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(56, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(133, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 27);
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
            label1.Location = new Point(17, 4);
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
            label2.Location = new Point(690, 6);
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
            txtIdPedido.Location = new Point(802, 5);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(198, 35);
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 214);
            dataGridView1.TabIndex = 10;
            // 
            // NovoPedido
            // 
            NovoPedido.BackColor = Color.Black;
            NovoPedido.Controls.Add(label9);
            NovoPedido.Controls.Add(radioButton2);
            NovoPedido.Controls.Add(radioButton1);
            NovoPedido.Controls.Add(label8);
            NovoPedido.Controls.Add(label7);
            NovoPedido.Controls.Add(label6);
            NovoPedido.Controls.Add(button2);
            NovoPedido.Controls.Add(textBox7);
            NovoPedido.Controls.Add(textBox6);
            NovoPedido.Controls.Add(textBox5);
            NovoPedido.Controls.Add(label5);
            NovoPedido.Controls.Add(textBox4);
            NovoPedido.Controls.Add(label4);
            NovoPedido.Controls.Add(textBox2);
            NovoPedido.Controls.Add(textBox1);
            NovoPedido.Controls.Add(ItemPedido);
            NovoPedido.ForeColor = Color.FromArgb(219, 179, 91);
            NovoPedido.Location = new Point(17, 241);
            NovoPedido.Name = "NovoPedido";
            NovoPedido.Size = new Size(657, 282);
            NovoPedido.TabIndex = 11;
            NovoPedido.TabStop = false;
            NovoPedido.Text = "Item de pedido";
            NovoPedido.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(477, 86);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 23;
            label9.Text = "R$ ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.FromArgb(219, 179, 91);
            radioButton2.Location = new Point(486, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Real";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.FromArgb(219, 179, 91);
            radioButton1.Location = new Point(485, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Percentual";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(486, 5);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 20;
            label8.Text = "Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(395, 40);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 19;
            label7.Text = "Quant.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(312, 42);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 18;
            label6.Text = "Valor Unit";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(551, 60);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveBorder;
            textBox7.Font = new Font("Segoe UI", 10F);
            textBox7.Location = new Point(477, 60);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(67, 25);
            textBox7.TabIndex = 17;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveBorder;
            textBox6.Font = new Font("Segoe UI", 10F);
            textBox6.Location = new Point(395, 60);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(67, 25);
            textBox6.TabIndex = 16;
            textBox6.Text = "1";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveBorder;
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(312, 60);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(77, 25);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(140, 45);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 14;
            label5.Text = "Descrição";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveBorder;
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.Location = new Point(135, 60);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(171, 25);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(10, 46);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Codigo de Barras";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(7, 60);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(122, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(6, 14);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(98, 25);
            textBox1.TabIndex = 4;
            // 
            // ItemPedido
            // 
            ItemPedido.Controls.Add(tabPage1);
            ItemPedido.Controls.Add(tabPage2);
            ItemPedido.Location = new Point(0, 103);
            ItemPedido.Name = "ItemPedido";
            ItemPedido.SelectedIndex = 0;
            ItemPedido.Size = new Size(657, 179);
            ItemPedido.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ForeColor = Color.FromArgb(219, 179, 91);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(649, 151);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item de Pedido";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.ForeColor = Color.FromArgb(219, 179, 91);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(649, 151);
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
            Controls.Add(NovoPedido);
            Controls.Add(label1);
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
            NovoPedido.ResumeLayout(false);
            NovoPedido.PerformLayout();
            ItemPedido.ResumeLayout(false);
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
        private GroupBox NovoPedido;
        private TabControl ItemPedido;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
    }
}
       
