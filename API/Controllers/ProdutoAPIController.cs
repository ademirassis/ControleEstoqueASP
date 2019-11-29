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
    [Route("api/Produto")]
    [ApiController]
    public class ProdutoAPIController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;

        public ProdutoAPIController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }


        //GET: /api/Produto/BuscarProdutoPorId/1
        [HttpGet]
        [Route("BuscarProdutoPorId/{id}")] 
        public IActionResult BuscarProdutoPorId(int id) 
        {
            Produto p = _produtoDAO.BuscarProdutoPorId(id);
            if (p != null)
            {
                return Ok(p);
            }
            return NotFound(new { msg = "Produto não encontrado!" });
        }


        //GET: /api/Produto/ListarProdutos
        [HttpGet]
        [Route("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoDAO.ListarProdutos());
        }

    }
}