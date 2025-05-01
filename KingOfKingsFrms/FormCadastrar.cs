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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntVoltar_Click(object sender, EventArgs e) // método para voltar para o form de login
        {
            FormPrincipal formPrincipal = new();
            formPrincipal.Show();
            this.Hide();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastrar_Click_1(object sender, EventArgs e) // método para cadastrar o usuário
        {
            Usuario usuario = new(txtNome.Text, txtCpf.Text, txtEmail.Text, cmbTipo_usuario.Text, txtSenha.Text);
            usuario.inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário {usuario.Nome} gravado com sucesso com o ID {usuario.Id}");
            FormCadastrar_Load(sender, e);
        }

        private void cmbTipo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
