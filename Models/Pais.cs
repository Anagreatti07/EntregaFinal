using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Tipo Saida")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
