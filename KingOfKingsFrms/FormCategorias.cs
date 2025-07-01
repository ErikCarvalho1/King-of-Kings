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

    public partial class FormCategorias : Form
    {
        private Form frmaAtivo; // Alterado de 'object' para 'Form'

        private void FormClose() // método para fechar o form ativo
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close(); // Agora 'Close()' é válido porque 'frmaAtivo' é do tipo 'Form'
            }
        }

        private void FormPainel(Form frm) // método para abrir o form no painel
        {
            FormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
           frm.BringToFront();
            frm.Show();
        }

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormPainel(new FormPedido());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
