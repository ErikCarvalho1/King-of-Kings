using ComercialTDSClass;
using KingOfKingsClass;
using KingoOfKingsClass;
using MySqlX.XDevAPI;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            
           
        }

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

        private void btninserir_Click(object sender, EventArgs e)
        {

            string tipoEnd = cmbTipoEndereco.SelectedItem.ToString();
            tipoEnd = tipoEnd.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                    Convert.ToInt32(txtClienteId.Text),
                    mxtCep.Text,
                    txtLogradouro.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtUf.Text,
                    tipoEnd
                );
            
            endereco.Inserir();
            CarregaGrid(int.Parse(txtClienteId.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaGrid(int.Parse(txtClienteId.Text));
        }

    

        private void mxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mxtCep_Leave(object sender, EventArgs e)
        {
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mxtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(mxtCep.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
                txtNumero.Focus();

            }
        }
        private void CarregaGrid(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorClienteId(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                {
                    int rowIndex = dgvEnderecos.Rows.Add(); // Adiciona uma nova linha e retorna o índice
                    dgvEnderecos.Rows[rowIndex].Cells[0].Value = endereco.Id;
                    dgvEnderecos.Rows[rowIndex].Cells[1].Value = endereco.Cep;
                    dgvEnderecos.Rows[rowIndex].Cells[2].Value = endereco.Logradouro;
                    dgvEnderecos.Rows[rowIndex].Cells[3].Value = endereco.Numero;
                    dgvEnderecos.Rows[rowIndex].Cells[4].Value = endereco.Complemento;
                    dgvEnderecos.Rows[rowIndex].Cells[5].Value = endereco.Bairro;
                    dgvEnderecos.Rows[rowIndex].Cells[6].Value = endereco.Cidade;
                    while (dgvEnderecos.Columns.Count < 9)
                    {
                        dgvEnderecos.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    dgvEnderecos.Rows[rowIndex].Cells[7].Value = endereco.Uf;
                    dgvEnderecos.Rows[rowIndex].Cells[8].Value = endereco.TipoEndereco;
                }
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
