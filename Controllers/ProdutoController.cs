using Microsoft.AspNetCore.Mvc;
using SistemaCadastro.Repositories;
using SistemaCadastro.Models;

namespace SistemaCadastro.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CategoriaFactory _categoriaFactory;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaFactory = new CategoriaFactory();
        }

        public IActionResult Exibir()
        {
            ViewBag.Produto = "Produtos";
            var produtos = _produtoRepository.Produtos;
            return View(produtos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public void CalcularPreco(Produto produto)
        {
            decimal custo = produto.Custo;
            ICategoria categoria = _categoriaFactory.CriarCategoria(produto.Categoria);
            decimal preco = categoria.CalcularPreco(custo);
            produto.Preco = preco;
        }
        public RedirectToActionResult Salvar(Produto produto)
        {
            CalcularPreco(produto);
            _produtoRepository.CadastrarProduto(produto);
            return RedirectToAction("Exibir");
        }

        public RedirectToActionResult Atualizar(Produto produto)
        {
            CalcularPreco(produto);
            _produtoRepository.AtualizarProduto(produto);
            return RedirectToAction("Exibir");
        }

        public RedirectToActionResult Remover(int id)
        {
            var produto = _produtoRepository.GetProdutoById(id);
            _produtoRepository.RemoverProduto(produto);
            return RedirectToAction("Exibir");
        }

        public IActionResult Editar(int id)
        {
            var produto = _produtoRepository.GetProdutoById(id);
            return View(produto);
        }
    }
}
