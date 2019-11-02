using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoqueASP.DAL;
using ControleEstoqueASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoqueASP.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CategoriaDAO _categoriaDAO;

        public CategoriaController(CategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_categoriaDAO.ListarCategorias());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Remover(int? id)
        {
            if (id != null)
            {
                _categoriaDAO.RemoverCategoria(id);
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int ?id)
        {
            if (id != null)
            {
                return View(_categoriaDAO.BuscarCategoriaPorId(id));
            }
            else
            {
                //redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }



        [HttpPost]
        public IActionResult Cadastrar(Categoria c)
        {
            if (ModelState.IsValid)
            {
                if (_categoriaDAO.CadastrarCategoria(c))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Essa categoria já existe!");
                return View(c);
            }
            return View(c);
        }

        [HttpPost]
        public IActionResult Alterar(Categoria c)
        {
            _categoriaDAO.AlterarCategoria(c);
            return RedirectToAction("Index");
        }
    }
}