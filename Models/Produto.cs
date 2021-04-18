using System.ComponentModel.DataAnnotations;

namespace SistemaCadastro.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Custo { get; set; }
        public int Quantidade { get; set; }
        
        [StringLength(1)]
        public string Categoria { get; set; }
    }
}
