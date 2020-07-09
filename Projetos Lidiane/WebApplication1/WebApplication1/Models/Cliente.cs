using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {
        //public int id { get; set; }
        
        public string Nome { get; set; }

        public Cliente(string texto)
        {
            this.Nome = texto;
        }
    }
}
