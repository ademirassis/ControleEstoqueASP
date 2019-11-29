using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class DevolucaoDAO
    {
        private readonly Context _context;
        public DevolucaoDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void LancaDevolucao(Movimento m)
        {
            Devolucao d = new Devolucao();

            d.Produto = m.Produto;
            d.Categoria = m.Categoria;
            d.Fornecedor = m.Fornecedor;
            d.Quantidade = m.Quantidade;

            _context.Devolucoes.Add(d);
            _context.SaveChanges();
        }

        public List<Devolucao> BuscarDevolucoes()
        {
            return _context.Devolucoes.Include("Produto").Include("Categoria").Include("Fornecedor").ToList();
        }
    }
}
