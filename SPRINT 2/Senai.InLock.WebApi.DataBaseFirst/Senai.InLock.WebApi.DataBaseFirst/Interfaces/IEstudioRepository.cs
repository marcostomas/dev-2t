﻿using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    /// <summary>
    /// Interface responsável pelo EstudioRepository
    /// </summary>
    interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios</returns>
        List<Estudios> Listar();

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        Estudios BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        void Cadastrar(Estudios novoEstudio);

        /// <summary>
        /// Atualiza os dados de um estudio ao passar um id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estudioAtualizado"></param>
        void Atualizar(int id, Estudios estudioAtualizado);

        /// <summary>
        /// Apaga os dados de um estudio ao passar um id
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
