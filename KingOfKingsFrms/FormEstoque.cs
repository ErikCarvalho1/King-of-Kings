using KingOfKingsClass;
using KingoOfKingsClass;
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
                dgvEstoque.Rows[linha].Cells["column2"].Value = item.Descricao;



                linha++;
            }

        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {

            string id = produtoId.Text.Trim();
            string quantidade = txtquantidade.Text.Trim();
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(quantidade))
            {
                MessageBox.Show("Preencha o ID e a quantidade.");
                return;
            }

            bool encontrou = false;

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue;

                // Compara o valor da célula da coluna "Id" com o ID digitado
                var cellId = row.Cells["Id"].Value;

                if (cellId != null && cellId.ToString() == id)
                {
                    row.Cells["Quantidade"].Value = quantidade;
                    row.Cells["DataMovimento"].Value = dataAtual;

                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Produto com esse ID não foi encontrado.");
            }







        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {


            string termo = txtNome.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termo))
            {
                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            string novaQuantidade = txtquantidade.Text.Trim();
            bool encontrou = false;



            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue; // Pula a linha vazia de inserção

                // Verifica se alguma célula da linha contém o termo buscado
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(termo))
                    {
                        row.Visible = true;
                        encontrou = true;

                        // Exemplo: altera uma célula "Quantidade" se você quiser fazer isso
                        // row.Cells["Quantidade"].Value = novaQuantidade;

                        break;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Nenhum item encontrado.");
            }


        }

        private void txtAdicionarEstoque_ValueChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string idAlvo = produtoId.Text.Trim();
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

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string quantidadeTexto = txtquantidade.Text.Trim();
            string dataTexto = dateUltimoMovimento.Text.Trim(); // ou dateUltimoMovimento.SelectedDate se for DatePicker

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(quantidadeTexto) &&
                !string.IsNullOrWhiteSpace(dataTexto))
            {
                if (double.TryParse(quantidadeTexto, out double quantidade) &&
                    quantidade > 0 &&
                    DateTime.TryParse(dataTexto, out DateTime data))
                {
                    Estoque estoque = new Estoque
                    {

                        Quantidade = quantidade,
                        DataUltimoMovimento = data
                    };

                    estoque.Inserir(); // salva no banco ou lista

                    if (estoque.Id > 0) // ou outro critério de sucesso
                    {
                        MessageBox.Show("Produto inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir o produto.");
                    }

                }
            }
        }
    }
}
















