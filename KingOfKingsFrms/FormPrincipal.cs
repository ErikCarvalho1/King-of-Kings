
using KingoOfKingsClass;
using KingOfKingsclass;
namespace KingOfKingsFrms
    

{
    public partial class FormPrincipal : Form

    {
        private Form frmaAtivo;// guarda o form atual no paine
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPainel(Form frm) // método para abrir o form no painel
        {
            ActiveFormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void ActiveFormClose() // método para fechar o form ativo
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close();
            }
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();

        }

        private void bntHistorico_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastrar_Click(object sender, EventArgs e) // método para abrir o form de cadastro 
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bntUsuarios_Click(object sender, EventArgs e) // método para abrir o form de usuários
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            var registro = new ResgistroDeAcesso();
           // registro.RegistrarSaida();
            Application.Exit();

        }

        private void eddeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCategorias());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCategorias());
        }
    }
}
