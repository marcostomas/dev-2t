using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBd.Domains;
using WebApiBd.Repositories;

namespace WebApiBd.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class SelecaoController : ControllerBase
    {
        SelecoesRepository selecoesRepository = new SelecoesRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
            //return Ok(new { message = "ok" });
            return Ok(selecoesRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Selecao selecao)
        {
            try
            {
                selecoesRepository.Cadastrar(selecao);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                selecoesRepository.Deletar(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Selecao selecao = selecoesRepository.BuscarPorId(id);
            if(selecao == null)
            {
                return NotFound();
            }

            return Ok(selecao);
        }

        [HttpPut]
        public IActionResult Atualizar(Selecao selecao)
        {
            try
            {
                Selecao selecaoBuscada = selecoesRepository.BuscarPorId(selecao.Id);

                if (selecaoBuscada == null)
                    return NotFound();

                selecoesRepository.Atualizar(selecao);
                return Ok();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
