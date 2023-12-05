using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Entrada do Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data da Entrada")]
        public DateTime DataEntrada { get; set; } 

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade Entrada")]
        public int QuantidadeEntrada { get; set; } 

    }
}
