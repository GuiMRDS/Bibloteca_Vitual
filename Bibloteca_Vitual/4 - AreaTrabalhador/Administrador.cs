using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Vitual._4___AreaTrabalhador
{
    public class Administrador : Usuario
    {
        public Administrador(string nomeUsuario, string senha)
            : base(nomeUsuario, senha)
        {
        }

        public override bool ValidarLogin(string login, string senha)
        {
            // Aqui podemos adicionar validações extras se quiser
            return base.ValidarLogin(login, senha);
        }
    }
}
