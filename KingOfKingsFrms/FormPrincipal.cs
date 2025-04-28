
namespace KingOfKingsFrms
    

{
    public partial class FormPrincipal : Form

    {
        private Form frmaAtivo;// guarda o form atual no paine
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPainel(Form frm) //
        {
            ActiveFormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
            panel6.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void ActiveFormClose()
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close();
            }
        }  
        private void ActiveFormClose(object sender, EventArgs e)
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

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
          
            FormPainel(new FormCadastrar());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {   
        }
    }
}
