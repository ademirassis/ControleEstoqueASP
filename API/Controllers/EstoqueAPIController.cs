using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/Estoque")]
    [ApiController]
    public class EstoqueAPIController : Controller
    {
        private readonly EstoqueDAO _estoqueDAO;

        public EstoqueAPIController(EstoqueDAO estoqueDAO)
        {
            _estoqueDAO = estoqueDAO;
        }


        //GET: /api/Estoque/ListarEstoquePorProduto
        [HttpGet]
        [Route("ListarEstoquePorProduto")]
        public IActionResult ListarEstoquePorProduto()
        {
            return Ok(_estoqueDAO.ListarEstoquePorProduto());
        }

        //GET: /api/Estoque/BuscarEstoquePorProduto/1
        [HttpGet]
        [Route("BuscarEstoquePorProduto/{id}")]
        public IActionResult BuscarEstoquePorProduto(int id)
        {
            Estoque e = _estoqueDAO.BuscarEstoquePorProduto(id);
            if (e != null)
            {
                return Ok(e);
            }
            return NotFound(new { msg = "Produto não encontrado!" });
        }
    }
}