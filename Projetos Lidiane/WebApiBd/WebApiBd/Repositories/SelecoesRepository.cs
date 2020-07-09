using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBd.Contexts;
using WebApiBd.Domains;

namespace WebApiBd.Repositories
{
    public class SelecoesRepository
    {

        public List<Selecao> Listar()
        {
            using(WebApiBdContext ctx = new WebApiBdContext())
            {
                return ctx.Selecao.ToList();
            }
        }

        public void Cadastrar(Selecao selecao)
        {
            using (WebApiBdContext ctx = new WebApiBdContext())
            {
                ctx.Selecao.Add(selecao);
                ctx.SaveChanges();
            }
        }

        public void Deletar (int id)
        {
            using (WebApiBdContext ctx = new WebApiBdContext())
            {
                Selecao selecaoId = ctx.Selecao.Find(id);
                ctx.Selecao.Remove(selecaoId);
                ctx.SaveChanges();
            }
        }

        public Selecao BuscarPorId(int id)
        {
            using(WebApiBdContext ctx = new WebApiBdContext ())
            {
                return ctx.Selecao.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Atualizar(Selecao selecao)
        {
            using(WebApiBdContext ctx = new WebApiBdContext ())
            {
                Selecao selecaoAtualizada = ctx.Selecao.FirstOrDefault(x => x.Id == selecao.Id);
                selecaoAtualizada.Nome = selecao.Nome;
                ctx.Selecao.Update(selecaoAtualizada);
                ctx.SaveChanges();
            }
        }
    }
}
