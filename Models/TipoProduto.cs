using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("TipoProdutoId")]
        [Display(Name = "Tipo Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descricao do Tipo Saida")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
