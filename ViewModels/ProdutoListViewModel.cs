using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaCadastro.Models;

namespace SistemaCadastro.ViewModels
{
    public class ProdutoListViewModel
    {
        public IEnumerable<Produto> produtos { get; set; }
    }
}
