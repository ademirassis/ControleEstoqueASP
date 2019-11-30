using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ControleEstoqueASP.Controllers
{
    [Authorize]
    //[Authorize(Roles = "ADM")]
    public class MovimentoController : Controller
    {
        private readonly MovimentoDAO _movimentoDAO;
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly FornecedorDAO _fornecedorDAO;
        private readonly EstoqueDAO _estoqueDAO;
        private readonly DevolucaoDAO _devolucaoDAO;

        public MovimentoController(MovimentoDAO movimentoDAO, ProdutoDAO produtoDAO,
            CategoriaDAO categoriaDAO, FornecedorDAO fornecedorDAO, EstoqueDAO estoqueDAO, DevolucaoDAO devolucaoDAO)
        {
            _movimentoDAO = movimentoDAO;
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _fornecedorDAO = fornecedorDAO;
            _estoqueDAO = estoqueDAO;
            _devolucaoDAO = devolucaoDAO;
        }

        public IActionResult Index()
        {
            ViewBag.Produtos = new SelectList(_produtoDAO.ListarProdutos(), "Id", "Nome", "Preco");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.DataHora = DateTime.Now;

            //return View(_movimentoDAO.ListarMovimento());
            return View(_estoqueDAO.ListarEnderecoEstoqueSituacao());
        }

        public IActionResult RMovimento()
        {
            ViewBag.Produtos = new SelectList(_produtoDAO.ListarProdutos(), "Id", "Nome", "Preco");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.DataHora = DateTime.Now;

            return View(_movimentoDAO.ListarMovimento());
        }

        public IActionResult RPosicao()
        {
            ViewBag.Produtos = new SelectList(_produtoDAO.ListarProdutos(), "Id", "Nome", "Preco");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.DataHora = DateTime.Now;

            return View(_movimentoDAO.ListarMovimento());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Produtos = new SelectList(_produtoDAO.ListarProdutos(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            string[] tipoMovimento = new string[] { "Entrada", "Saida", "Devolucao" };
            ViewBag.TipoMovimento = new SelectList(tipoMovimento);
            ViewBag.EnderecoEstoque = new SelectList(_estoqueDAO.ListarEnderecoEstoqueDisponivel(), "Id", "Localizacao");
            return View();
        }

        public JsonResult LoadCategoria(int produtoId)
        {
            Produto produtoSelected = _produtoDAO.BuscarProdutoPorId(produtoId);
            if (produtoSelected != null)
            {
                ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
                Categoria categoriaSelected = _categoriaDAO.BuscarCategoriaPorId(produtoSelected.Categoria.Id);
                return Json(categoriaSelected);
            }
            return Json("");
        }

        public JsonResult LoadFornecedor(int produtoId)
        {
            Produto produtoSelected = _produtoDAO.BuscarProdutoPorId(produtoId);
            if (produtoSelected != null)
            {
                ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
                Fornecedor fornecedorSelected = _fornecedorDAO.BuscarFornecedorPorId(produtoSelected.Fornecedor.Id);
                return Json(fornecedorSelected);
            }
            return Json("");
        }

        public IActionResult Detalhes(int id)
        {
            return View(_movimentoDAO.BuscarMovimentoPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Movimento m, int? drpProdutos, string drpTipoMovimento, int? drpEnderecoEstoque)
        {
            ViewBag.Produtos = new SelectList(_produtoDAO.ListarProdutos(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");

            if (ModelState.IsValid)
            {
                m.Produto = _produtoDAO.BuscarProdutoPorId(drpProdutos);
                m.TipoMovimento = drpTipoMovimento;
                m.Categoria = m.Produto.Categoria;
                m.Fornecedor = m.Produto.Fornecedor;

                switch (drpTipoMovimento)
                {
                    case "Entrada":
                        m.EnderecoEstoque = (_estoqueDAO.BuscarEstoquePorId(drpEnderecoEstoque)).Localizacao;
                        _movimentoDAO.LancarMovimento(m);
                        _estoqueDAO.AtualizarEnderecoEstoque(m);
                        break;
                    case "Saida":
                        _movimentoDAO.LancarMovimento(m);
                        _estoqueDAO.AtualizarEnderecoEstoque(m);
                        break;
                    case "Devolucao":
                        _devolucaoDAO.LancaDevolucao(m);
                        _estoqueDAO.AtualizarEnderecoEstoque(m);
                        break;
                    default:
                        break;
                }

                return RedirectToAction("Index");
            }
            return View(m);
        }
    }
}