
using KingoOfKingsClass;
using KingOfKingsclass;
namespace KingOfKingsFrms
    

{
    public partial class FormPrincipal : Form
    {
        public void FormClose() // m�todo para fechar o form ativo
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close();
            }
        }
        public Form frmaAtivo;// guarda o form atual no painel
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public void FormPainel(Form frm) // m�todo para abrir o form no painel
        {
            FormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
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

        private void bntCadastrar_Click(object sender, EventArgs e) // m�todo para abrir o form de cadastro 
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bntUsuarios_Click(object sender, EventArgs e) // m�todo para abrir o form de usu�rios
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

        private void cadastroDeUsuariosEVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void cadastroDeCupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCupom());
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCliente());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCadastroCategoria());
        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormListarProduto());
        }

        private void cadastroDeProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPainel(new FrmProduto());
        }
    }
}
