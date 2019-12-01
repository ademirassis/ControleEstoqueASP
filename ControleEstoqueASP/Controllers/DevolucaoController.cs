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
    public class DevolucaoController : Controller
    {
        private readonly DevolucaoDAO _devolucaoDAO;

        public DevolucaoController(DevolucaoDAO devolucaoDAO)
        {
            _devolucaoDAO = devolucaoDAO;
        }

        public IActionResult RDevolucao()
        {
            return View(_devolucaoDAO.BuscarDevolucoes());
        }
    }
}