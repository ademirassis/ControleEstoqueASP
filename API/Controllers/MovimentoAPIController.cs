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
        private readonly DevolucaoDAO _devolucaoDAO;

        public MovimentoAPIController(MovimentoDAO movimentoDAO, DevolucaoDAO devolucaoDAO)
        {
            _movimentoDAO = movimentoDAO;
            _devolucaoDAO = devolucaoDAO;
        }

        //GET: /api/Movimento/ListarMovimento
        [HttpGet]
        [Route("ListarMovimento")]
        public IActionResult ListarMovimento()
        {
            return Ok(_movimentoDAO.ListarMovimento());
        }
        //GET: /api/Movimento/ListarDevolucao
        [HttpGet]
        [Route("ListarDevolucao")]
        public IActionResult ListarDevolucao()
        {
            return Ok(_devolucaoDAO.BuscarDevolucoes());
        }
    }
}