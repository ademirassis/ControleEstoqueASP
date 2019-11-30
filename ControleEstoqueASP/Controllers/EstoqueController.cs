using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ControleEstoqueASP.Controllers
{
    [Authorize]
    //[Authorize(Roles = "ADM")]
    public class EstoqueController : Controller
    {
        private readonly EstoqueDAO _estoqueDAO;

        public EstoqueController(EstoqueDAO estoqueDAO)
        {
            _estoqueDAO = estoqueDAO;
        }

        public IActionResult RMapaEstoque()
        {
            return View(_estoqueDAO.ListarEnderecoEstoqueSituacao());
        }



    }
}