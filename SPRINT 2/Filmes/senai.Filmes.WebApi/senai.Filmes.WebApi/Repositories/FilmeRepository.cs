using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string stringConexao = "Data Source=DEV801\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";


        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Filmes SET Titulo = @Titulo WHERE IdFilme = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@ID",filme.IdFilme);
                    cmd.Parameters.AddWithValue("@Titulo", filme.Titulo);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Filmes SET Titulo = @Titulo WHERE IdFilme = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Titulo", filme.Titulo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public FilmeDomain BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT IdFilme, Titulo FROM Filmes WHERE IdFilme = @ID";

                conn.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            Titulo = rdr["Titulo"].ToString()
                        };

                        return filme;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(FilmeDomain filme)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Filmes(Titulo) VALUES (@Titulo)";

                SqlCommand cmd = new SqlCommand(queryInsert, conn);

                cmd.Parameters.AddWithValue("@Titulo", filme.Titulo);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Filmes WHERE IdFilme = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FilmeDomain> Listar()
        {
            List<FilmeDomain> filmes = new List<FilmeDomain>();

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT IdFilme, Titulo FROM Filmes";

                conn.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, conn))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),
                            Titulo = rdr["Titulo"].ToString(),
                            //IdGenero = Convert.ToInt32(rdr[2])
                        };

                        filmes.Add(filme);
                    }
                }
            }

            return filmes;
        }
    }
}
