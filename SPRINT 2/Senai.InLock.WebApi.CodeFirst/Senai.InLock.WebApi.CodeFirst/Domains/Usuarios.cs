using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Domains
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Column(TypeName ="VARCHAR (255)")]
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Column(TypeName = "VARCHAR (150)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public int IdTipoUsuario { get; set; }

        public TiposUsuario TipoUsuario { get; set; }
    }
}
