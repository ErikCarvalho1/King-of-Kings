namespace KingOfKingsFrms
{
    partial class FormCupom
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            label6 = new Label();
            txtLimiteDeUso = new TextBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            dateDataDeInicio = new DateTimePicker();
            dateDataDeExpiracao = new DateTimePicker();
            label8 = new Label();
            label4 = new Label();
            cbxCupomTipo = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbxTipoDesconto = new ComboBox();
            txtDesconto = new TextBox();
            txtValorMaximoDesconto = new TextBox();
            txtValorPedidoMinimo = new TextBox();
            checkBoxAtivo = new CheckBox();
            btnAtualizar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            dataGridView1 = new DataGridView();
            ClnTitulo = new DataGridViewTextBoxColumn();
            ClnCupomTipo = new DataGridViewTextBoxColumn();
            clnLimiteParaMesmoUsuario = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDataInicio = new DataGridViewTextBoxColumn();
            clnDataEnspiração = new DataGridViewTextBoxColumn();
            clnValorpedido = new DataGridViewTextBoxColumn();
            clnValorMaximo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTipoDesconto = new DataGridViewTextBoxColumn();
            txtDescricao = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(288, 18);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 0;
            label1.Text = "Cupom de Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(28, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "&Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(28, 102);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "&Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(224, 101);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de &inicio";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(26, 75);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(182, 23);
            txtTitulo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(227, 54);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 8;
            label6.Text = "C&upom Tipo ";
            // 
            // txtLimiteDeUso
            // 
            txtLimiteDeUso.Location = new Point(445, 75);
            txtLimiteDeUso.Name = "txtLimiteDeUso";
            txtLimiteDeUso.Size = new Size(182, 23);
            txtLimiteDeUso.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(448, 55);
            label7.Name = "label7";
            label7.Size = new Size(151, 15);
            label7.TabIndex = 10;
            label7.Text = "&Limite para mesmo usuário";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(25, 121);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 23);
            txtCodigo.TabIndex = 11;
            // 
            // dateDataDeInicio
            // 
            dateDataDeInicio.Location = new Point(224, 121);
            dateDataDeInicio.Name = "dateDataDeInicio";
            dateDataDeInicio.Size = new Size(200, 23);
            dateDataDeInicio.TabIndex = 12;
            // 
            // dateDataDeExpiracao
            // 
            dateDataDeExpiracao.Location = new Point(445, 121);
            dateDataDeExpiracao.Name = "dateDataDeExpiracao";
            dateDataDeExpiracao.Size = new Size(200, 23);
            dateDataDeExpiracao.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(447, 102);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 14;
            label8.Text = "Data de &expiração";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(26, 152);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 15;
            label4.Text = "&Valor pedido minimo";
            // 
            // cbxCupomTipo
            // 
            cbxCupomTipo.FormattingEnabled = true;
            cbxCupomTipo.Location = new Point(223, 74);
            cbxCupomTipo.Name = "cbxCupomTipo";
            cbxCupomTipo.Size = new Size(200, 23);
            cbxCupomTipo.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.FromArgb(219, 179, 91);
            label9.Location = new Point(224, 154);
            label9.Name = "label9";
            label9.Size = new Size(147, 15);
            label9.TabIndex = 17;
            label9.Text = "V&alor máximo de desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.FromArgb(219, 179, 91);
            label10.Location = new Point(407, 154);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 18;
            label10.Text = "&Desconto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = Color.FromArgb(219, 179, 91);
            label11.Location = new Point(550, 154);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 19;
            label11.Text = "&Tipo desconto";
            // 
            // cbxTipoDesconto
            // 
            cbxTipoDesconto.FormattingEnabled = true;
            cbxTipoDesconto.Items.AddRange(new object[] { "Percentual", "Real" });
            cbxTipoDesconto.Location = new Point(550, 172);
            cbxTipoDesconto.Name = "cbxTipoDesconto";
            cbxTipoDesconto.Size = new Size(169, 23);
            cbxTipoDesconto.TabIndex = 20;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(407, 172);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(137, 23);
            txtDesconto.TabIndex = 21;
            // 
            // txtValorMaximoDesconto
            // 
            txtValorMaximoDesconto.Location = new Point(224, 172);
            txtValorMaximoDesconto.Name = "txtValorMaximoDesconto";
            txtValorMaximoDesconto.Size = new Size(147, 23);
            txtValorMaximoDesconto.TabIndex = 22;
            // 
            // txtValorPedidoMinimo
            // 
            txtValorPedidoMinimo.Location = new Point(24, 172);
            txtValorPedidoMinimo.Name = "txtValorPedidoMinimo";
            txtValorPedidoMinimo.Size = new Size(147, 23);
            txtValorPedidoMinimo.TabIndex = 23;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.BackColor = Color.Transparent;
            checkBoxAtivo.ForeColor = Color.FromArgb(219, 179, 91);
            checkBoxAtivo.Location = new Point(652, 215);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(57, 19);
            checkBoxAtivo.TabIndex = 5;
            checkBoxAtivo.Text = "Ativar";
            checkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Black;
            btnAtualizar.ForeColor = Color.FromArgb(219, 179, 91);
            btnAtualizar.Location = new Point(46, 444);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.ForeColor = Color.FromArgb(219, 179, 91);
            btnEditar.Location = new Point(127, 444);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.ForeColor = Color.FromArgb(219, 179, 91);
            btnSalvar.Location = new Point(224, 444);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Black;
            btnExcluir.ForeColor = Color.FromArgb(219, 179, 91);
            btnExcluir.Location = new Point(317, 444);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 27;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(219, 179, 91);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 179, 91);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 179, 91);
            btnSair.ForeColor = Color.FromArgb(219, 179, 91);
            btnSair.Location = new Point(410, 444);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 28;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClnTitulo, ClnCupomTipo, clnLimiteParaMesmoUsuario, clnCodigo, clnDataInicio, clnDataEnspiração, clnValorpedido, clnValorMaximo, clnDesconto, clnTipoDesconto });
            dataGridView1.Location = new Point(12, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 179, 91);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1004, 203);
            dataGridView1.TabIndex = 29;
            // 
            // ClnTitulo
            // 
            ClnTitulo.HeaderText = "Titulo";
            ClnTitulo.Name = "ClnTitulo";
            // 
            // ClnCupomTipo
            // 
            ClnCupomTipo.HeaderText = "Cupom Tipo";
            ClnCupomTipo.Name = "ClnCupomTipo";
            // 
            // clnLimiteParaMesmoUsuario
            // 
            clnLimiteParaMesmoUsuario.HeaderText = "Limite de uso";
            clnLimiteParaMesmoUsuario.Name = "clnLimiteParaMesmoUsuario";
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Codigo";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnDataInicio
            // 
            clnDataInicio.HeaderText = "Data inicio";
            clnDataInicio.Name = "clnDataInicio";
            // 
            // clnDataEnspiração
            // 
            clnDataEnspiração.HeaderText = "Data Expiração";
            clnDataEnspiração.Name = "clnDataEnspiração";
            // 
            // clnValorpedido
            // 
            clnValorpedido.HeaderText = "Valor pedido Minimo";
            clnValorpedido.Name = "clnValorpedido";
            // 
            // clnValorMaximo
            // 
            clnValorMaximo.HeaderText = "Valor Max Desconto";
            clnValorMaximo.Name = "clnValorMaximo";
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            // 
            // clnTipoDesconto
            // 
            clnTipoDesconto.HeaderText = "Tipo Desconto";
            clnTipoDesconto.Name = "clnTipoDesconto";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(85, 204);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(548, 23);
            txtDescricao.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F);
            label12.ForeColor = Color.FromArgb(219, 179, 91);
            label12.Location = new Point(21, 207);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 31;
            label12.Text = "&Descriçao";
            // 
            // FormCupom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leaoFundo;
            ClientSize = new Size(1028, 503);
            Controls.Add(label12);
            Controls.Add(txtDescricao);
            Controls.Add(dataGridView1);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnAtualizar);
            Controls.Add(txtValorPedidoMinimo);
            Controls.Add(txtValorMaximoDesconto);
            Controls.Add(txtDesconto);
            Controls.Add(cbxTipoDesconto);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbxCupomTipo);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(dateDataDeExpiracao);
            Controls.Add(dateDataDeInicio);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(txtLimiteDeUso);
            Controls.Add(label6);
            Controls.Add(txtTitulo);
            Controls.Add(checkBoxAtivo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCupom";
            Text = "Cupom";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtTitulo;
        private Label label6;
        private TextBox txtLimiteDeUso;
        private Label label7;
        private TextBox txtCodigo;
        private DateTimePicker dateDataDeInicio;
        private DateTimePicker dateDataDeExpiracao;
        private Label label8;
        private Label label4;
        private ComboBox cbxCupomTipo;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cbxTipoDesconto;
        private TextBox txtDesconto;
        private TextBox txtValorMaximoDesconto;
        private TextBox txtValorPedidoMinimo;
        private CheckBox checkBoxAtivo;
        private Button btnAtualizar;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnSair;
        private DataGridView dataGridView1;
        private TextBox txtDescricao;
        private Label label12;
        private DataGridViewTextBoxColumn ClnTitulo;
        private DataGridViewTextBoxColumn ClnCupomTipo;
        private DataGridViewTextBoxColumn clnLimiteParaMesmoUsuario;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDataInicio;
        private DataGridViewTextBoxColumn clnDataEnspiração;
        private DataGridViewTextBoxColumn clnValorpedido;
        private DataGridViewTextBoxColumn clnValorMaximo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTipoDesconto;
    }
}