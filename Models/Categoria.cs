using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SistemaCadastro.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
