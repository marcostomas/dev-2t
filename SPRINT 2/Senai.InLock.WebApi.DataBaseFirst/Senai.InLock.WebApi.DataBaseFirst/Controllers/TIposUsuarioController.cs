using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repositories;

namespace Senai.InLock.WebApi.DataBaseFirst.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposUsuarioController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _tiposUsuarioRepository que irá receber todos os métodos implementados na interface
        /// </summary>
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Retorna todos os Tipos de Usuario
        /// </summary>
        /// <returns>Uma lista de Tipos Usuario e Status Code 200 - OK</returns>
        // GET: api/TIposUsuario
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tiposUsuarioRepository.Listar());
        }

        /// <summary>
        /// Retorna o Tipo Usuario através do id
        /// </summary>
        /// <param name="id">Id do estudio que será buscado</param>
        /// <returns>Um Tipo Usuario buscado e um Status Code 200 - OK</returns>
        // GET: api/TIposUsuario/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Cria um objeto tipoUsuarioBuscado que irá receber o tipo de usuário buscado no banco de dados
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se algum tipo de usuário foi encontrado
            if (tipoUsuarioBuscado != null)
            {
                // Caso seja, retorna os dados buscados e um status code 200 - Ok
                return Ok(tipoUsuarioBuscado);
            }

            // Caso não seja, retorna um status code 404 - NotFound com a mensagem
            return NotFound("Nenhum tipo de usuário encontrado para o identificador informado");
        }

        /// <summary>
        /// Cadastra um novo Tipo Usuario
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario que será cadastrado</param>
        /// <returns>Um Status Code - 201 Created</returns>
        // POST: api/TIposUsuario
        [HttpPost]
        public IActionResult Post(TiposUsuario novoTipoUsuario)
        {
            _tiposUsuarioRepository.Cadastrar(novoTipoUsuario);

            return Created("http://localhost:5000/api/Usuarios", novoTipoUsuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            // Cria um objeto tipoUsuarioBuscado que irá receber o tipo de usuário buscado no banco de dados
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se algum tipo de usuário foi encontrado
            if (tipoUsuarioBuscado != null)
            {
                // Tenta atualizar o registro
                try
                {
                    // Faz a chamada para o método .Atualizar();
                    _tipoUsuarioRepository.Atualizar(id, tipoUsuarioAtualizado);

                    // Retorna um status code 204 - No Content
                    return NoContent();
                }
                // Caso ocorra algum erro
                catch (Exception erro)
                {
                    // Retorna BadRequest e o erro
                    return BadRequest(erro);
                }

            }

            // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
            // e um bool para representar que houve erro
            return NotFound
                (
                    new
                    {
                        mensagem = "Tipo de usuário não encontrado",
                        erro = true
                    }
                );
        }

        /// <summary>
        /// Deleta um tipo de usuário
        /// </summary>
        /// <param name="id">ID do tipo de usuário que será deletado</param>
        /// <returns>Retorna um status code com uma mensagem de sucesso ou erro</returns>
        /// dominio/api/TiposUsuario/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Cria um objeto tipoUsuarioBuscado que irá receber o tipo de usuário buscado no banco de dados
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se o tipo de usuário foi encontrado
            if (tipoUsuarioBuscado != null)
            {
                // Caso seja, faz a chamada para o método .Deletar()
                _tipoUsuarioRepository.Deletar(id);

                // e retorna um status code 200 - Ok com uma mensagem de sucesso
                return Ok($"O tipo de usuário {id} foi deletado com sucesso!");
            }

            // Caso não seja, retorna um status code 404 - NotFound com a mensagem
            return NotFound("Nenhum tipo de usuário encontrado para o identificador informado");
        }

    }
}
