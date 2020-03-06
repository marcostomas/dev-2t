using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IUsuariosRepository
    {
        /// <summary>
        /// Lista todos os Usuarios
        /// </summary>
        /// <returns> E retorna uma lista </returns>
        List<Usuarios> Listar();

        /// <summary>
        /// Busca os usuário existentes no banco de dados pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna todos os usuários existentes</returns>
        Usuarios BuscarPorId(int id);
        
        /// <summary>
        /// Cadastra novos usuarios
        /// </summary>
        /// <param name="novoUsuario"></param>
        void Cadastrar(Usuarios novoUsuario);

        /// <summary>
        /// Atualiza o(s) dados de um usuário passando o id do mesmo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UsuarioAtualizado"></param>
        void Atualizar(int id, Usuarios UsuarioAtualizado);

        /// <summary>
        /// Apaga os dados de usuario do banco
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);


    }
}
