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
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

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
            ItemPedido Item = new(
                int.Parse(txtIdPedido.Text),
                Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            Item.inserir();
            if (Item.Id > 0)
            {
                //CarregarItens(int.Parse(txtIdPedido.Text));
            }
        }
    }
}
