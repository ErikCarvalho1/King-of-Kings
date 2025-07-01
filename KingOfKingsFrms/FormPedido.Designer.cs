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
            txtUsuario = new TextBox();
            button1 = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            txtCLiente = new TextBox();
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
            grbItens = new GroupBox();
            label9 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnAdicionarItem = new Button();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label5 = new Label();
            txtDrescricao = new TextBox();
            label4 = new Label();
            txtCodBarra = new TextBox();
            txtIdProd = new TextBox();
            abaItemPedido = new TabControl();
            tabPage1 = new TabPage();
            dgvItensPedido = new DataGridView();
            ClnCodBarras = new DataGridViewTextBoxColumn();
            clnDrescricao = new DataGridViewTextBoxColumn();
            ClnValorUnit = new DataGridViewTextBoxColumn();
            ClnQaunt = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            ClnTotal = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            txtObservacao = new TextBox();
            txtSubTotalItens = new TextBox();
            Label10 = new Label();
            pnlcategoria = new Panel();
            label15 = new Label();
            pictureBoxshortsfem = new PictureBox();
            pictureBoxBone = new PictureBox();
            pictureBoxshortsmasc = new PictureBox();
            pictureBoxkit = new PictureBox();
            pictureBoxcropeed = new PictureBox();
            pictureBoxCamMasc = new PictureBox();
            pictureBoxChinelo = new PictureBox();
            pictureBoxMoletom = new PictureBox();
            grbIndentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            abaItemPedido.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            tabPage2.SuspendLayout();
            pnlcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxshortsfem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxshortsmasc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxkit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxcropeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamMasc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChinelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoletom).BeginInit();
            SuspendLayout();
            // 
            // grbIndentificacao
            // 
            grbIndentificacao.BackColor = Color.Black;
            grbIndentificacao.Controls.Add(txtUsuario);
            grbIndentificacao.Controls.Add(button1);
            grbIndentificacao.Controls.Add(btnInserePedido);
            grbIndentificacao.Controls.Add(txtIdCliente);
            grbIndentificacao.Controls.Add(txtCLiente);
            grbIndentificacao.Controls.Add(label3);
            grbIndentificacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbIndentificacao.ForeColor = Color.FromArgb(219, 179, 91);
            grbIndentificacao.Location = new Point(687, 46);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(313, 184);
            grbIndentificacao.TabIndex = 0;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(108, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 25);
            txtUsuario.TabIndex = 4;
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
            btnInserePedido.Click += btnInserePedido_Click;
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
            // txtCLiente
            // 
            txtCLiente.BackColor = SystemColors.ActiveBorder;
            txtCLiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCLiente.Location = new Point(133, 71);
            txtCLiente.Name = "txtCLiente";
            txtCLiente.ReadOnly = true;
            txtCLiente.Size = new Size(176, 27);
            txtCLiente.TabIndex = 1;
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
            txtTotal.Location = new Point(712, 427);
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
            txtSubTotal.Location = new Point(712, 253);
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
            txtDescontoItens.Location = new Point(712, 316);
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
            btnFechar.Location = new Point(889, 458);
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
            txtDescontoPedido.Location = new Point(712, 370);
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
            label11.Location = new Point(710, 234);
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
            label12.Location = new Point(710, 297);
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
            label13.Location = new Point(712, 351);
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
            label14.Location = new Point(712, 408);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 9;
            label14.Text = "Total ";
            // 
            // grbItens
            // 
            grbItens.BackColor = Color.Black;
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(radioButton2);
            grbItens.Controls.Add(radioButton1);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(btnAdicionarItem);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDrescricao);
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(txtCodBarra);
            grbItens.Controls.Add(txtIdProd);
            grbItens.Controls.Add(abaItemPedido);
            grbItens.ForeColor = Color.FromArgb(219, 179, 91);
            grbItens.Location = new Point(17, 241);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(657, 282);
            grbItens.TabIndex = 11;
            grbItens.TabStop = false;
            grbItens.Text = "Item de pedido";
            grbItens.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(478, 88);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 23;
            label9.Text = "R$ ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.FromArgb(219, 179, 91);
            radioButton2.Location = new Point(485, 38);
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
            radioButton1.Location = new Point(486, 20);
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
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackgroundImage = (Image)resources.GetObject("btnAdicionarItem.BackgroundImage");
            btnAdicionarItem.FlatStyle = FlatStyle.Flat;
            btnAdicionarItem.Location = new Point(551, 60);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(100, 42);
            btnAdicionarItem.TabIndex = 12;
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += button2_Click;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.BackColor = SystemColors.ActiveBorder;
            txtDescontoItem.Font = new Font("Segoe UI", 10F);
            txtDescontoItem.Location = new Point(477, 60);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.ReadOnly = true;
            txtDescontoItem.Size = new Size(67, 25);
            txtDescontoItem.TabIndex = 17;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = SystemColors.ActiveBorder;
            txtQuantidade.Font = new Font("Segoe UI", 10F);
            txtQuantidade.Location = new Point(395, 60);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.ReadOnly = true;
            txtQuantidade.Size = new Size(67, 25);
            txtQuantidade.TabIndex = 16;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorUnit
            // 
            txtValorUnit.BackColor = SystemColors.ActiveBorder;
            txtValorUnit.Font = new Font("Segoe UI", 10F);
            txtValorUnit.Location = new Point(312, 60);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.ReadOnly = true;
            txtValorUnit.Size = new Size(77, 25);
            txtValorUnit.TabIndex = 15;
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
            // txtDrescricao
            // 
            txtDrescricao.BackColor = SystemColors.ActiveBorder;
            txtDrescricao.Font = new Font("Segoe UI", 10F);
            txtDrescricao.Location = new Point(135, 60);
            txtDrescricao.Name = "txtDrescricao";
            txtDrescricao.ReadOnly = true;
            txtDrescricao.Size = new Size(171, 25);
            txtDrescricao.TabIndex = 13;
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
            // txtCodBarra
            // 
            txtCodBarra.BackColor = SystemColors.ActiveBorder;
            txtCodBarra.Font = new Font("Segoe UI", 10F);
            txtCodBarra.Location = new Point(7, 60);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.ReadOnly = true;
            txtCodBarra.Size = new Size(122, 25);
            txtCodBarra.TabIndex = 5;
            txtCodBarra.TextChanged += textBox2_TextChanged;
            // 
            // txtIdProd
            // 
            txtIdProd.BackColor = SystemColors.ActiveBorder;
            txtIdProd.Font = new Font("Segoe UI", 10F);
            txtIdProd.Location = new Point(6, 14);
            txtIdProd.Name = "txtIdProd";
            txtIdProd.ReadOnly = true;
            txtIdProd.Size = new Size(98, 25);
            txtIdProd.TabIndex = 4;
            // 
            // abaItemPedido
            // 
            abaItemPedido.Controls.Add(tabPage1);
            abaItemPedido.Controls.Add(tabPage2);
            abaItemPedido.Location = new Point(0, 103);
            abaItemPedido.Name = "abaItemPedido";
            abaItemPedido.SelectedIndex = 0;
            abaItemPedido.Size = new Size(657, 179);
            abaItemPedido.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvItensPedido);
            tabPage1.ForeColor = Color.FromArgb(219, 179, 91);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(649, 151);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item de Pedido";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { ClnCodBarras, clnDrescricao, ClnValorUnit, ClnQaunt, clnDesconto, ClnTotal });
            dgvItensPedido.GridColor = Color.Black;
            dgvItensPedido.Location = new Point(0, 1);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(649, 150);
            dgvItensPedido.TabIndex = 0;
            // 
            // ClnCodBarras
            // 
            ClnCodBarras.HeaderText = "Cod Barras";
            ClnCodBarras.Name = "ClnCodBarras";
            // 
            // clnDrescricao
            // 
            clnDrescricao.HeaderText = "Descrição";
            clnDrescricao.Name = "clnDrescricao";
            clnDrescricao.Width = 156;
            // 
            // ClnValorUnit
            // 
            ClnValorUnit.HeaderText = "Valor Unit";
            ClnValorUnit.Name = "ClnValorUnit";
            ClnValorUnit.Width = 90;
            // 
            // ClnQaunt
            // 
            ClnQaunt.HeaderText = "Quant";
            ClnQaunt.Name = "ClnQaunt";
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            // 
            // ClnTotal
            // 
            ClnTotal.HeaderText = "Total";
            ClnTotal.Name = "ClnTotal";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtObservacao);
            tabPage2.ForeColor = Color.FromArgb(219, 179, 91);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(649, 151);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Observação";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(3, 3);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(644, 148);
            txtObservacao.TabIndex = 0;
            // 
            // txtSubTotalItens
            // 
            txtSubTotalItens.BackColor = SystemColors.ActiveBorder;
            txtSubTotalItens.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubTotalItens.Location = new Point(680, 494);
            txtSubTotalItens.Name = "txtSubTotalItens";
            txtSubTotalItens.ReadOnly = true;
            txtSubTotalItens.Size = new Size(109, 29);
            txtSubTotalItens.TabIndex = 12;
            txtSubTotalItens.Text = "0,00";
            txtSubTotalItens.TextAlign = HorizontalAlignment.Right;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Black;
            Label10.ForeColor = Color.FromArgb(219, 179, 91);
            Label10.Location = new Point(680, 472);
            Label10.Name = "Label10";
            Label10.Size = new Size(77, 15);
            Label10.TabIndex = 13;
            Label10.Text = "SubTotalItens";
            // 
            // pnlcategoria
            // 
            pnlcategoria.Controls.Add(label15);
            pnlcategoria.Controls.Add(pictureBoxshortsfem);
            pnlcategoria.Controls.Add(pictureBoxBone);
            pnlcategoria.Controls.Add(pictureBoxshortsmasc);
            pnlcategoria.Controls.Add(pictureBoxkit);
            pnlcategoria.Controls.Add(pictureBoxcropeed);
            pnlcategoria.Controls.Add(pictureBoxCamMasc);
            pnlcategoria.Controls.Add(pictureBoxChinelo);
            pnlcategoria.Controls.Add(pictureBoxMoletom);
            pnlcategoria.Location = new Point(27, 46);
            pnlcategoria.Name = "pnlcategoria";
            pnlcategoria.Size = new Size(641, 197);
            pnlcategoria.TabIndex = 14;
            pnlcategoria.Paint += panel1_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(219, 179, 91);
            label15.Location = new Point(153, -54);
            label15.Name = "label15";
            label15.Size = new Size(195, 34);
            label15.TabIndex = 54;
            label15.Text = "Categorias";
            // 
            // pictureBoxshortsfem
            // 
            pictureBoxshortsfem.BackgroundImage = (Image)resources.GetObject("pictureBoxshortsfem.BackgroundImage");
            pictureBoxshortsfem.Location = new Point(236, 88);
            pictureBoxshortsfem.Name = "pictureBoxshortsfem";
            pictureBoxshortsfem.Size = new Size(100, 81);
            pictureBoxshortsfem.TabIndex = 53;
            pictureBoxshortsfem.TabStop = false;
            // 
            // pictureBoxBone
            // 
            pictureBoxBone.BackgroundImage = (Image)resources.GetObject("pictureBoxBone.BackgroundImage");
            pictureBoxBone.Location = new Point(3, 1);
            pictureBoxBone.Name = "pictureBoxBone";
            pictureBoxBone.Size = new Size(100, 81);
            pictureBoxBone.TabIndex = 52;
            pictureBoxBone.TabStop = false;
            pictureBoxBone.Click += pictureBoxBone_Click;
            // 
            // pictureBoxshortsmasc
            // 
            pictureBoxshortsmasc.BackgroundImage = (Image)resources.GetObject("pictureBoxshortsmasc.BackgroundImage");
            pictureBoxshortsmasc.Location = new Point(354, 88);
            pictureBoxshortsmasc.Name = "pictureBoxshortsmasc";
            pictureBoxshortsmasc.Size = new Size(100, 81);
            pictureBoxshortsmasc.TabIndex = 51;
            pictureBoxshortsmasc.TabStop = false;
            // 
            // pictureBoxkit
            // 
            pictureBoxkit.BackgroundImage = (Image)resources.GetObject("pictureBoxkit.BackgroundImage");
            pictureBoxkit.Location = new Point(130, 88);
            pictureBoxkit.Name = "pictureBoxkit";
            pictureBoxkit.Size = new Size(100, 81);
            pictureBoxkit.TabIndex = 50;
            pictureBoxkit.TabStop = false;
            // 
            // pictureBoxcropeed
            // 
            pictureBoxcropeed.BackgroundImage = (Image)resources.GetObject("pictureBoxcropeed.BackgroundImage");
            pictureBoxcropeed.Location = new Point(19, 100);
            pictureBoxcropeed.Name = "pictureBoxcropeed";
            pictureBoxcropeed.Size = new Size(100, 81);
            pictureBoxcropeed.TabIndex = 49;
            pictureBoxcropeed.TabStop = false;
            // 
            // pictureBoxCamMasc
            // 
            pictureBoxCamMasc.BackgroundImage = (Image)resources.GetObject("pictureBoxCamMasc.BackgroundImage");
            pictureBoxCamMasc.Location = new Point(354, 3);
            pictureBoxCamMasc.Name = "pictureBoxCamMasc";
            pictureBoxCamMasc.Size = new Size(100, 81);
            pictureBoxCamMasc.TabIndex = 48;
            pictureBoxCamMasc.TabStop = false;
            // 
            // pictureBoxChinelo
            // 
            pictureBoxChinelo.BackgroundImage = (Image)resources.GetObject("pictureBoxChinelo.BackgroundImage");
            pictureBoxChinelo.Location = new Point(248, 1);
            pictureBoxChinelo.Name = "pictureBoxChinelo";
            pictureBoxChinelo.Size = new Size(100, 81);
            pictureBoxChinelo.TabIndex = 47;
            pictureBoxChinelo.TabStop = false;
            // 
            // pictureBoxMoletom
            // 
            pictureBoxMoletom.BackgroundImage = (Image)resources.GetObject("pictureBoxMoletom.BackgroundImage");
            pictureBoxMoletom.Location = new Point(127, 1);
            pictureBoxMoletom.Name = "pictureBoxMoletom";
            pictureBoxMoletom.Size = new Size(100, 81);
            pictureBoxMoletom.TabIndex = 46;
            pictureBoxMoletom.TabStop = false;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(1005, 528);
            Controls.Add(pnlcategoria);
            Controls.Add(Label10);
            Controls.Add(txtSubTotalItens);
            Controls.Add(grbItens);
            Controls.Add(label1);
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
            Load += FormPedido_Load_1;
            grbIndentificacao.ResumeLayout(false);
            grbIndentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            abaItemPedido.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlcategoria.ResumeLayout(false);
            pnlcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxshortsfem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxshortsmasc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxkit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxcropeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamMasc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChinelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoletom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIndentificacao;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtCLiente;
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
        private GroupBox grbItens;
        private TabControl abaItemPedido;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtIdProd;
        private Label label4;
        private TextBox txtCodBarra;
        private Button btnAdicionarItem;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label5;
        private TextBox txtDrescricao;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private DataGridView dgvItensPedido;
        private DataGridViewTextBoxColumn ClnCodBarras;
        private DataGridViewTextBoxColumn clnDrescricao;
        private DataGridViewTextBoxColumn ClnValorUnit;
        private DataGridViewTextBoxColumn ClnQaunt;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn ClnTotal;
        private TextBox txtObservacao;
        private TextBox txtSubTotalItens;
        private Label Label10;
        private TextBox txtUsuario;
        private Panel pnlcategoria;
        private Label label15;
        private PictureBox pictureBoxshortsfem;
        private PictureBox pictureBoxBone;
        private PictureBox pictureBoxshortsmasc;
        private PictureBox pictureBoxkit;
        private PictureBox pictureBoxcropeed;
        private PictureBox pictureBoxCamMasc;
        private PictureBox pictureBoxChinelo;
        private PictureBox pictureBoxMoletom;
    }
}
       
