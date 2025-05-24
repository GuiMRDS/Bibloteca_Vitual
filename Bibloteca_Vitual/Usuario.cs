using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Vitual
{
    public class Usuario
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string senha)
        {
            NomeUsuario = nome;
            Senha = senha;
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            return NomeUsuario == usuario && Senha == senha;
        }
    }

}
