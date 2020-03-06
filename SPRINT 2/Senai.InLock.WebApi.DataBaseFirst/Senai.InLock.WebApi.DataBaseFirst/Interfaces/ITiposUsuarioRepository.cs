using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface ITiposUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de usuário
        /// </summary>
        /// <returns>Retorna uma lista dos tipos de usuarios</returns>
        List<TiposUsuario> Listar();

        /// <summary>
        /// Busca o tipo de usuário pelo seu id 
        /// </summary>
        /// <returns>Retorna o nome do tipo de usuário ao passar o id</returns>
        TiposUsuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra novos tipos de usuarios
        /// </summary>
        /// <param name="novoTipoUsuario"></param>
        void Cadastrar(TiposUsuario novoTipoUsuario);

        /// <summary>
        /// Atualiza o tipo de usuario ao passar o id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoUsuarioAtualizado"></param>
        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuario
        /// </summary>
        /// <param name="tipoUsuario"></param>
        void Deletar(TiposUsuario tipoUsuario); 




    }
}
