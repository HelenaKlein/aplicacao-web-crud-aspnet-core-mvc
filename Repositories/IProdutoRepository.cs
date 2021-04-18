using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaCadastro.Models;

namespace SistemaCadastro.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        Produto GetProdutoById(int ProdutoId);
        public void CadastrarProduto(Produto produto);
        public void RemoverProduto(Produto produto);
        public void AtualizarProduto(Produto produto);
    }
}
