using ComercialTDSClass;
using KingOfKingsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfKingsFrms
{

    public partial class FormPedido : Form
    {
        private Form frmaAtivo; // Alterado de 'object' para 'Form'

        private void FormClose() // método para fechar o form ativo
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close(); // Agora 'Close()' é válido porque 'frmaAtivo' é do tipo 'Form'
            }
        }

        private void FormPainel(Form frm) // método para abrir o form no painel
        {
            FormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
            pnlcategoria.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
            pedido.Desconto = double.Parse(txtDescontoPedido.Text);
            pedido.Status = "F";

            if (pedido.Atualizar())
            {
                MessageBox.Show($"Pedido {pedido.Id} foi fechado com sucesso \n");

            }

            dgvItensPedido.Rows.Clear();
            txtIdPedido.Clear();
            txtIdPedido.Focus();
            // Limpar todos
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
            pedido.Inserir();
            if (pedido.Id > 0)
            {
                txtIdPedido.Text = pedido.Id.ToString();
                grbIndentificacao.Enabled = false;
                grbItens.Enabled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemPedido Items = new(
                int.Parse(txtIdPedido.Text),
                Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            Items.inserir();
            if (Items.Id > 0)
            {
                CarregarItens(int.Parse(txtIdPedido.Text));
            }
        }
        private void CarregarItens(int PedidoId)
        {
            var itens = ItemPedido.ObterlistaPorPedidoId(PedidoId);
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double subTotal = 0;
            double descontos = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{(linha + 1).ToString().PadLeft(2, '0')}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBarras;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                descontos += item.Desconto;
                double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = totalItem;
                subTotal += totalItem; // subtotal = subtotal + totalitem
                linha++;
            }
            Label10.Text = subTotal.ToString();
            txtSubTotal.Text = (subTotal + descontos).ToString();
            txtDescontoItens.Text = descontos.ToString();
            txtTotal.Text = subTotal.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {

        }

        private void grbIndentificacao_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
           {
                var cliente = Cliente.ObterPorId(int.Parse(txtIdCliente.Text));
                if (cliente.Id > 0)
                {
                    txtCLiente.Text = cliente.Nome;
                }

           } 
        }

        private void txtCLiente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
