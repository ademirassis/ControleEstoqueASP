using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoqueASP.DAL;
using ControleEstoqueASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoqueASP.Controllers
{
    [Authorize]
    //[Authorize(Roles = "ADM")]
    public class FornecedorController : Controller
    {
        private readonly FornecedorDAO _fornecedorDAO;

        public FornecedorController(FornecedorDAO fornecedorDAO)
        {
            _fornecedorDAO = fornecedorDAO;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_fornecedorDAO.ListarFornecedores());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Remover(int? id)
        {
            if (id != null)
            {
                _fornecedorDAO.RemoverFornecedor(id);
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
                return View(_fornecedorDAO.BuscarFornecedorPorId(id));
            }
            else
            {
                //redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }



        [HttpPost]
        public IActionResult Cadastrar(Fornecedor f)
        {
            if (ModelState.IsValid)
            {
                if (_fornecedorDAO.CadastrarFornecedor(f))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Essa categoria já existe!");
                return View(f);
            }
            return View(f);
        }

        [HttpPost]
        public IActionResult Alterar(Fornecedor f)
        {
            _fornecedorDAO.AlterarFornecedor(f);
            return RedirectToAction("Index");
        }
    }
}