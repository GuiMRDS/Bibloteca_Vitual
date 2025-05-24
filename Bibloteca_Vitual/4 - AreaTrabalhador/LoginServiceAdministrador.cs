using Bibloteca_Vitual._2___Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Vitual._4___AreaTrabalhador
{
    public class LoginServiceAdministrador
    {
        private List<Administrador> administradores;

        public LoginServiceAdministrador()
        {
            administradores = new List<Administrador>
        {
            new Administrador("admin", "admin123"),
            new Administrador("gerente", "senhaSegura")
        };
        }

        public bool Autenticar(string login, string senha)
        {
            return administradores.Any(a => a.ValidarLogin(login, senha));
        }
    }
}
