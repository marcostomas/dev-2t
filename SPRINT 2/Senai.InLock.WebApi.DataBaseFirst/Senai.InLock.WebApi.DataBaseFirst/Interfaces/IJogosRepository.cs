using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IJogosRepository
    {
        /// <summary>
        /// Lista os jogos com os estudios
        /// </summary>
        /// <returns>Retorna uma lista de jogos com os dados de estudio</returns>
        List<Jogos> Listar();

        /// <summary>
        /// Mostra o jogo pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna um jogo com seus dados e os dados do estudio que desenvolveu</returns>
        Jogos BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo jogo e seus respectivos dados
        /// </summary>
        /// <param name="novoJogo"></param>
        void Cadastrar(Jogos novoJogo);

        /// <summary>
        /// Atualiza os dados de um jogo pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jogoAtualizado"></param>
        void Atualizar(int id, Jogos jogoAtualizado);

        /// <summary>
        /// Apaga um jogo pelo id
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);

        /// <summary>
        /// Lista os jogos de um estudio
        /// </summary>
        /// <returns></returns>
        List<Estudios> ListarJogoPorEstudio();


    }
}
