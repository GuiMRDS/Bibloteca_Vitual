using Bibloteca_Vitual._2___Login;
using Bibloteca_Vitual._4___AreaTrabalhador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteca_Vitual.AreaTrabalhador
{
    public partial class FormsAreaTrabalhador : Form
    {
        private LoginServiceAdministrador loginService;
        public FormsAreaTrabalhador()
        {
            InitializeComponent();
            loginService = new LoginServiceAdministrador();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 sair = new Form1();
            sair.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (loginService.Autenticar(login, senha))
            {
                MessageBox.Show("Login de administrador bem-sucedido!");
                FormsAreaTrabalhador painel = new FormsAreaTrabalhador();
                painel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
