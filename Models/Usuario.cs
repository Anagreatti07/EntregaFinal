using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Usuario")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuario")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "Email do Usuario")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha do Usuario")]
        public string SenhaUsuario { get; set; } = string.Empty;
    }
}
