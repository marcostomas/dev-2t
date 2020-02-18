﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using senai.Filmes.WebApi.Repositories;

namespace senai.Filmes.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints referentes aos generos
    /// </summary>

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class GenerosController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _generoRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        /// dominio/api/Generos
        [HttpGet]
        public IEnumerable<GeneroDomain> Get()
        {
            // Faz a chamada para o método .Listar();
            return _generoRepository.Listar();
        }

        [HttpPost]
        public IActionResult Criar(GeneroDomain generoRecebido)
        {
            _generoRepository.Criar(generoRecebido);

            //return ok(); //Status code: 200
            //return BadRequest(); //Status code: 400
            //return NotFound();  //Status code: 404
            //return StatusCode(203);  // Status code: 203

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _generoRepository.Deletar(id);

            return NoContent();
        }


        [HttpGet ("id")]
        public IActionResult GetById(int id)
        {
            GeneroDomain generoBuscado = _generoRepository.GetById(id);

            if(generoBuscado == null)
            {
                return NotFound("Nenhum gênero encontrado");
            }

            return StatusCode(200, generoBuscado);
        }

        [HttpPut{"@id}"]
        public IActionResult PutUrl(int id, GeneroDomain generoAtualizado)
        {
            GeneroDomain generoBuscado = _generoRepository.GetById(id);

            if (generoBuscado == null)
            {
                return NotFound(
                    new
                    {
                        menssagem = "Gênero não encontrado",
                        erro = true
                    }
                );
            }

            try (Exception erro)
            {
                _generoRepository.AtualizarIdUrl(id, generoAtualizado);
            }
            catch
            {
                return BadRequest(erro);
            }
        }
    }
}