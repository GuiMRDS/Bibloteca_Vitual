using Bibloteca_Vitual.AreaTrabalhador;
using Bibloteca_Vitual.Cadastrar;
using Bibloteca_Vitual.Login;

namespace Bibloteca_Vitual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FomsCadastro cadastro = new FomsCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            FormsAreaTrabalhador funcionario = new FormsAreaTrabalhador();
            funcionario.Show();
            this.Hide();
        }
    }
}
