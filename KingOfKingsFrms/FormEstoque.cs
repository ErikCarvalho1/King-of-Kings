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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }



        private void FormEstoque_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            int linha = 0;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.Rows.Clear();
            foreach (var item in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[linha].Cells["column1"].Value = item.Id;



                linha++;
            }

        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text.Trim();
            string quantidade = txtquantidade.Text.Trim();
            string dateUltimoMovimento = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (string.IsNullOrWhiteSpace(quantidade))


            {
                MessageBox.Show("Digite a quantidade.");
                return;
            }


            dgvEstoque.Rows[0].Cells["column2"].Value = quantidade;
            dgvEstoque.Rows[0].Cells["column3"].Value = dateUltimoMovimento;



        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {


            string termo = txtBuscar.Text.Trim().ToLower();


            if (string.IsNullOrWhiteSpace(termo))
            {
                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            string novaQuantidade = (string)txtquantidade.Text;
            bool encontrou = false;

        }

        private void txtAdicionarEstoque_ValueChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string idAlvo = txtId.Text.Trim(); 
            string novaQuantidade = txtquantidade.Text.Trim(); 

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.Cells["column1"].Value != null && row.Cells["column1"].Value.ToString() == idAlvo)
                {
                    row.Cells["column1"].Value = novaQuantidade; 
                    break; 
                }
            }
        }
    }
}











