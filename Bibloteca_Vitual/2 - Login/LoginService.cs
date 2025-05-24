using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Vitual._2___Login
{
    public class LoginService
    {
        private UsuarioService usuarioService;

        public LoginService()
        {
            usuarioService = new UsuarioService(); // Aqui você pode usar SQLite ou uma lista
        }

        public bool Autenticar(string login, string senha)
        {
            return usuarioService.ValidarLogin(login, senha);
        }
    }

}
