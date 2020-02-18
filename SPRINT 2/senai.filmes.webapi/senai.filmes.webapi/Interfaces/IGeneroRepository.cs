using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório Genero
    /// </summary>
    interface IGeneroRepository
    {
        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        List<GeneroDomain> Listar();

        //Retorno NomeMetodo (Parãmetro)
        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="genero">objeto gênero que será cadastrado</param>
        void Criar(GeneroDomain genero);

        /// <summary>
        /// Deletar um gênero
        /// </summary>
        /// <param name="genero">Id do gênero que será deletado</param>
        void Deletar(int id);

        /// <summary>
        /// Atualiza um gênero existente
        /// </summary>
        /// <param name="id">Id do gênero que será utitlizado</param>
        /// <param name="genero">Objeto que será atualizado</param>
        void AtualizarIdUrl(int id, GeneroDomain genero)

    }
}
