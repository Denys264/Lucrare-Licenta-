namespace Gestiune_Bar_proiect_LICENTA
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logare_Click(object sender, EventArgs e)
        {
            if (NumeUtilizator.Text=="barman" && Parola.Text=="raluele")
            {
                MeniuBarman f2 = new MeniuBarman();
                f2.Show();
                this.Hide();
            }
            else if (NumeUtilizator.Text=="123" && Parola.Text == "123")
            {
                MeniuAdministrator f3 = new MeniuAdministrator();
                f3.Show();
                this.Hide();
            }
        }
    }
}
