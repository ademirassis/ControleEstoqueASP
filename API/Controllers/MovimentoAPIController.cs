using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/Movimento")]
    [ApiController]
    public class MovimentoAPIController : Controller
    {
        private readonly MovimentoDAO _movimentoDAO;

        public MovimentoAPIController(MovimentoDAO movimentoDAO)
        {
            _movimentoDAO = movimentoDAO;
        }

        //GET: /api/Movimento/ListarMovimento
        [HttpGet]
        [Route("ListarMovimento")]
        public IActionResult ListarMovimento()
        {
            return Ok(_movimentoDAO.ListarMovimento());
        }
    }
}