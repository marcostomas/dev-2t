using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Domains
{
    public class FilmeDomain
    {
        public int idFilme {get ; set;}

        public string Titulo {get; set;}

        public int idGenero { get; set; }

        public GeneroDomain Genero { get; set; }
    }
}
