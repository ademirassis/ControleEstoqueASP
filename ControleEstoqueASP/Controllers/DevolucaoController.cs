using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoqueASP.Controllers
{
    [Authorize]
    //[Authorize(Roles = "ADM")]
    public class DevolucaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}