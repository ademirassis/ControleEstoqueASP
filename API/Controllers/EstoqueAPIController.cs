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
            List<dynamic> estoqueDyn = new List<dynamic>();
            List<Estoque> estoque = new List<Estoque>();

            estoque = _estoqueDAO.ListarEstoquePorProduto();

            foreach (Estoque item in estoque)
            {
                dynamic d = new
                {
                    Produto = item.Produto.Nome,
                    Categoria = item.Produto.Categoria.Nome,
                    Fornecedor = item.Produto.Fornecedor.Nome,
                    Localizacao = item.Localizacao,
                    Quantidade = item.Quantidade,
                    Preco = item.Produto.Preco.ToString("C2"),
                    Total = (Convert.ToInt32(item.Quantidade) * item.Produto.Preco).ToString("C2"),
                    AtualizadoEm = (item.AtualizadoEm).Day + "/" + (item.AtualizadoEm).Month + "/" + (item.AtualizadoEm).Year
                };
                estoqueDyn.Add(d);
            }

            return Ok(estoqueDyn);
        }
    }
}