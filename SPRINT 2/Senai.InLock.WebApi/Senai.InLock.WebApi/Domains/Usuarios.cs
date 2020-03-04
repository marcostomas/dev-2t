using System;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Domains
{
    public partial class Usuarios
    {
        public int Iusuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? IdTipoUsuario { get; set; }

        public TipoUsuarios IdTipoUsuarioNavigation { get; set; }
    }
}
