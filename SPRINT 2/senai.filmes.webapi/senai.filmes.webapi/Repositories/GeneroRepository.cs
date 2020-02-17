using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {   //Adiciona o Banco de Dados e define qual Banco usar
        //integrated security= true : usar em casa
        private string StringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa@132";

        public List<GeneroDomain> Listar()
        {
            List<GeneroDomain> generos = new List<GeneroDomain>();

            //só sera feita quando for necessario
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = " SELECT IdGenero, Genero FROM Genero";

                con.Open();

                SqlDataReader rdr;

                //  query que vou utilizar e qual a conexao vou utilizar
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    rdr = cmd.ExecuteReader();

                    //Enquanto tiver linhas para ler eu vou:
                    while (rdr.Read())
                    {   //Criar generos
                        GeneroDomain genero = new GeneroDomain
                        {
                            IdGenero = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Genero"].ToString()
                        };

                        //adicionar na lista 'generos'
                        generos.Add(genero);
                    }
                }
            }

            return generos;
        }
    }
}
