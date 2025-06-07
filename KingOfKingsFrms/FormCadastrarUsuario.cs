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
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
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
            if (txtId.Text == string.Empty)
            {
                // INSERIR
                if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty && cmbNivel.SelectedItem != null)
                {
                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado, true);
                    usuario.Inserir();

                    if (usuario.Id > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }

                //CarregaGrid();     // Método que você deve ter para atualizar a grade
                //LimpaControles();  // Método para limpar os campos
            }
            else
            {
                // ATUALIZAR
                if (cmbNivel.SelectedItem != null)
                {
                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(
                                int.Parse(txtId.Text),
                                txtNome.Text,
                                txtEmail.Text,
                                txtSenha.Text,
                                nivelSelecionado,
                                true
                            );

                    if (usuario.Atualizar())
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }
            }
        }

        private void cmbTipo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
