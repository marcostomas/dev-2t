using Microsoft.EntityFrameworkCore;
using Senai.InLock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Contexts
{
    /// <summary>
    /// Classe responsável pelo contexto do projeto
    /// Faz a comunicação entre a API e o Banco de Dados
    /// </summary>
    public class InLockContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Estudios> Estudios {get; set;}

        public DbSet<Jogos> Jogos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DEV801\\SQLEXPRESS; Database=InLock_Games_CodeFirst_M; user=sa pwd=sa@132");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
