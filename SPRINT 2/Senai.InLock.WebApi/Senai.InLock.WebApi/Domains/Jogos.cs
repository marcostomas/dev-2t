using System;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Domains
{
    public partial class Jogos
    {
        public int IdJogo { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }
        public int? IdEstudio { get; set; } //O ponto de interrogação indica que este atributo permite valores nulos

        public Estudio IdEstudioNavigation { get; set; }
    }
}
