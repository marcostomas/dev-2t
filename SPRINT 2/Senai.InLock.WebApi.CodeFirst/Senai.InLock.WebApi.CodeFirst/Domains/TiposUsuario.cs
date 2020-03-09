using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        //Define que será uma chave primária
        [Key]
        //Define o autoincremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoUsuario { get; set; }

        [Column(TypeName ="VARCHAR (255)")]
        [Required(ErrorMessage = "O Título do tipo de usuário é obrigatório")]
        public string Titulo { get; set; }
    }
}
