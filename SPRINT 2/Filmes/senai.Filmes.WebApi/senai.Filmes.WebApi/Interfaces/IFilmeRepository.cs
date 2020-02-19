using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    interface IFilmeRepository
    {
        //Lista os filmes
        List<FilmeDomain> Listar();

        //Insere novos filmes no banco
        void Cadastrar(FilmeDomain filme);

        //Atualiza um filme existente ao passar o id pelo corpo
        void AtualizarIdCorpo(FilmeDomain filme);

        //Atualiza um filme existente ao passar o id pela url
        void AtualizarIdUrl(int id, FilmeDomain filme);

        //Apaga um filme
        void Deletar(int id);

        //Busca um filme pelo id
        FilmeDomain BuscarPorId(int id);
    }
}
