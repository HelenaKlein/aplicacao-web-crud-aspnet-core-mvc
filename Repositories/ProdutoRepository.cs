using System.Collections.Generic;
using System.Linq;
using SistemaCadastro.Context;
using SistemaCadastro.Models;

namespace SistemaCadastro.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos;

        public void CadastrarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void RemoverProduto(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

         public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public Produto GetProdutoById(int ProdutoId)
        {
            return _context.Produtos.FirstOrDefault(l => l.Id == ProdutoId);
        }
    }
}
