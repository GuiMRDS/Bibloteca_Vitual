using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Vitual._2___Login
{
    public class UsuarioService
    {
        private List<Usuario> usuarios;

        public UsuarioService()
        {
            usuarios = new List<Usuario>
        {
            new Usuario("admin", "123"),
            new Usuario("joao", "senha123")
        };
        }

        public bool ValidarLogin(string nome, string senha)
        {
            return usuarios.Any(u => u.NomeUsuario == nome && u.Senha == senha);
        }
    }

}
