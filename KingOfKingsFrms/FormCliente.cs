using ComercialTDSClass;
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
<<<<<<< HEAD
            //if (txtId.Text == string.Empty)
            //{
            //    // INSERIR
            //    if (txtNome.Text != string.Empty &&txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty)
            //    {


            //        Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dtpDataNasc.Text));
            //        cliente.Inserir();

            //        if (cliente.Id > 0)
            //        {
            //            MessageBox.Show("Cliente cadastrado com sucesso!");
            //            //btnGravar.Enabled = false;
            //        }

            //    }

            //}
=======
>>>>>>> cf2906bdaff29fc865cf35f731d6ab1c74032502
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
            mxtCpf.ReadOnly = false;
            mxtTelefone.ReadOnly = false;
            dtpDataNasc.Enabled = true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

            CarregaGrid();
            limpaControles();
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
            mxtCpf.Text = cliente.Cpf;
            mxtTelefone.Text = cliente.Telefone;
            dtpDataNasc.Value = cliente.DataNascimento;

            //desabilita os campos
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            mxtCpf.ReadOnly = true;
            mxtTelefone.ReadOnly = true;
            dtpDataNasc.Enabled = false;

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
                dgvClientes.Rows[linha].Cells[5].Value = item.DataNascimento.ToShortDateString();


            }
        }
        public void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mxtCpf.Clear();
            mxtTelefone.Clear();
            dtpDataNasc.Value = DateTime.Now; // Reseta para a data atual



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        { 
        }

        private void bntGravar_Click(object sender, EventArgs e)
        {
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD


            string tipoEnd = cmbTipoEndereco.SelectedItem.ToString();
            tipoEnd = tipoEnd.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    mxtCep.Text,
                    txtLogradouro.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    cmbUF.Text,
                    tipoEnd
                );

            endereco.Inserir();
=======
            if (txtId.Text == string.Empty)
            {
                // INSERIR
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty)
                {


                    Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateDataNascimento.Text));
                    cliente.Inserir();

                    if (cliente.Id > 0)
                    {
                        if (maskCep.Text != string.Empty && txtLogradouro.Text != string.Empty &&
                        txtNumero.Text != string.Empty && txtComplemento.Text != string.Empty && txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && cmbUF.Text
                        != string.Empty && cmbTipoendereco.Text != string.Empty)
                        {
                          //  Endereco endereco = new(maskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cmbUF.Text, cmbTipoendereco.Text,cliente.Id);
                           // endereco.ClienteId = cliente.Id;
                           
                          //  if (endereco.ClienteId > 0)
                           // {
                                MessageBox.Show($"Cliente cadastrado com sucesso");
                                //btnGravar.Enabled = false;
                          //  }
                        }
                    }
>>>>>>> cf2906bdaff29fc865cf35f731d6ab1c74032502

        }
<<<<<<< HEAD

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new(
                    txtNome.Text,
                    mxtCpf.Text,
                    mxtTelefone.Text,
                    txtEmail.Text,
                    dtpDataNasc.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastrado com sucesso");
            }

        }
=======
        
>>>>>>> cf2906bdaff29fc865cf35f731d6ab1c74032502

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }





        private void maskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

<<<<<<< HEAD

            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCep.Text.Length == 8)
=======
        
            maskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskCep.Text.Length == 8)
>>>>>>> cf2906bdaff29fc865cf35f731d6ab1c74032502
            {
                WebCEP webCEP = new(maskCep.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                cmbUF.Text = webCEP.UF;
                txtNumero.Focus();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

    


     
        

        

        
    



