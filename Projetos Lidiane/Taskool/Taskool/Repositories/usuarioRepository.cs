using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskool.Models;

namespace Taskool.Repositories
{
    class usuarioRepository
    {
        //O Static define que só há uma lis
        private static List<Usuario> usuarios;

        public usuarioRepository()
        {
            if (usuarios == null)
                usuarios = new List<Usuario>();

            if (usuarios == null)
            {
                Usuario usuario = new Usuario
                {
                    codigo = 1,
                    nome = "Marcos",
                    email = "marcos@email.com",
                    senha = "1234",
                    telefone = "11987456123",
                    usuario = "mtomas"
                };
                   
            }
            //TODO: Terminar usuarioRepository
            //usuarios.Add(usuario);
        }



        //TODO: Terminar usuarioRepository
        //dgvAluno.DataSource = usuarios;
    }
}
