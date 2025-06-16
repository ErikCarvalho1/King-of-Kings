using KingOfKingsClass;
using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfKingsFrms
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                // INSERIR
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty) ;
                {


                    Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateDataNascimento.Text));
                    cliente.Inserir();

                    if (cliente.Id > 0)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            dateDataNascimento.Enabled = true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
           
            CarregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // recuperando o indice da linha do gride 
            int linha = dgvClientes.CurrentRow.Index;
            // recuperando o id do nivel na coluna, oculda, ID (0)
            int id = Convert.ToInt32(dgvClientes.Rows[linha].Cells[0].Value);
            var cliente = Cliente.ObterPorId(id);

            // //obter  o objeto nivel

            // preenche os campos com os dados do usuario
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
            dateDataNascimento.Value = cliente.DataNascimento;

            //desabilita os campos
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            dateDataNascimento.Enabled = false;

        }
        private void CarregaGrid()
        {
            List<Cliente> Lista = Cliente.ObterLista(); // Este método precisa retornar List<Cliente>
            if (Lista == null || Lista.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado.");
                return;
            }
            dgvClientes.Rows.Clear();
            foreach (var item in Lista)
            {
                int linha = dgvClientes.Rows.Add();
                dgvClientes.Rows[linha].Cells[0].Value = item.Id;
                dgvClientes.Rows[linha].Cells[1].Value = item.Nome;
                dgvClientes.Rows[linha].Cells[2].Value = item.Email;
                dgvClientes.Rows[linha].Cells[3].Value = item.Cpf;
                dgvClientes.Rows[linha].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[linha].Cells[4].Value = item.DataNascimento.ToShortDateString();


            }
        }
    }
}
     
        

        

        
    



