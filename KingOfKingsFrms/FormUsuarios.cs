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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            var lista = Usuario.ObterLista();
            int linha = 0;
            dgvUsuarios.Rows.Clear();

            foreach (var usuario in lista)
            {
                //if (usuario.Ativo)
                //{
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Tipo_Usuario;
                dgvUsuarios.Rows[linha].Cells[4].Value = usuario.Ativo;
                linha++;    
                //}
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                int linha = dgvUsuarios.CurrentRow.Index;
                int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);
                bool ativo = Convert.ToBoolean(dgvUsuarios.Rows[linha].Cells[4].Value);
            
            }

         private void bntBuscar_Click(object sender, EventArgs e)
          {

            var usuario = Usuario.ObterPorNome(txtNome.Text.Trim());

            if (usuario != null)
            {
                txtId.Text = usuario.Id.ToString();
                txtNome.Text = usuario.Nome;
                txtCpf.Text = usuario.Cpf_cnpj;
                txtEmail.Text = usuario.Email;
                cmbTipo_usuario.Text = usuario.Tipo_Usuario;
                txtSenha.Text = usuario.Senha;
                chkAtivo.Checked = usuario.Ativo;

            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
