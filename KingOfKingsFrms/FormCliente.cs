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
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty);
                {


                    Cliente cliente = new (txtNome.Text, txtCpf.Text, txtTelefone.Text,txtEmail.Text,DateTime.Parse(dateDataNascimento.Text));
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

        }
    }
}
