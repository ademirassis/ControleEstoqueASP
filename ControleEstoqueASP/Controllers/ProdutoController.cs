using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoqueASP.DAL;
using ControleEstoqueASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleEstoqueASP.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly FornecedorDAO _fornecedorDAO;

        public ProdutoController(ProdutoDAO produtoDAO,
            FornecedorDAO fornecedorDAO, CategoriaDAO categoriaDAO)
        {
            _produtoDAO = produtoDAO;
            _fornecedorDAO = fornecedorDAO;
            _categoriaDAO = categoriaDAO;
        }

        public IActionResult Index()
        {
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarProdutos());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            return View();
        }

        public IActionResult Remover(int? id)
        {
            if (id != null)
            {
                _produtoDAO.RemoverProduto(id);
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int? id)
        {
            if (id != null)
            {
                Produto p = _produtoDAO.BuscarProdutoPorId(id);

                SelectList fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
                foreach (var item in fornecedores)
                {
                    if(item.Value == p.Fornecedor.Id.ToString())
                    {
                        item.Selected = true;
                        break;
                    }
                }

                SelectList categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
                foreach (var item in categorias)
                {
                    if (item.Value == p.Categoria.Id.ToString())
                    {
                        item.Selected = true;
                        break;
                    }
                }

                ViewBag.Fornecedores = fornecedores;
                ViewBag.Categorias = categorias;

                return View(p);
            }
            else
            {
                //redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }



        [HttpPost]
        public IActionResult Cadastrar(Produto p, int drpFornecedores, int drpCategorias)
        {
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            if (ModelState.IsValid)
            {
                p.Fornecedor = _fornecedorDAO.BuscarFornecedorPorId(drpFornecedores);
                p.Categoria = _categoriaDAO.BuscarCategoriaPorId(drpCategorias);

                if (_produtoDAO.CadastrarProduto(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
                return View(p);
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Alterar(Produto p, int drpFornecedores, int drpCategorias)
        {
            ViewBag.Fornecedores = new SelectList(_fornecedorDAO.ListarFornecedores(), "Id", "Nome");
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarCategorias(), "Id", "Nome");
            if (ModelState.IsValid)
            {
                p.Fornecedor = _fornecedorDAO.BuscarFornecedorPorId(drpFornecedores);
                p.Categoria = _categoriaDAO.BuscarCategoriaPorId(drpCategorias);

                if (_produtoDAO.AlterarProduto(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
                return View(p);
            }
            return View(p);
        }
    }
}