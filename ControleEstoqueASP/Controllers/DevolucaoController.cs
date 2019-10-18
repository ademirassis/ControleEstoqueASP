using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoqueASP.Controllers
{
    public class DevolucaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}