using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private string StringConexao = "Data Source=DEV801\\SQLEXPRESS";

        public List<GeneroDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
