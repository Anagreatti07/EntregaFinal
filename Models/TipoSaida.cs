using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Tipo Saida")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descricao do Tipo Saida")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
