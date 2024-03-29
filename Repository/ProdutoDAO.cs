﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public bool CadastrarProduto(Produto p)
        {
            if (BuscarProdutoPorNome(p) == null)
            {
                _context.Produtos.Add(p);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Produto BuscarProdutoPorNome(Produto p) =>
            _context.Produtos.FirstOrDefault
            (x => x.Nome.Equals(p.Nome));

        public Produto BuscarProdutoPorId(int? id)
        {
            return _context.Produtos.
                Include(x => x.Categoria).
                Include(x => x.Fornecedor).
                FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool AlterarProduto(Produto p)
        {
            _context.Produtos.Update(p);
            _context.SaveChanges();
            return true;
        }

        public void RemoverProduto(int? id)
        {
            _context.Produtos.Remove(BuscarProdutoPorId(id));
            _context.SaveChanges();
        }

        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.
                Include(x => x.Categoria).Include(x => x.Fornecedor).
                ToList();
        }

        public Produto VinculoCategoria(Categoria c) =>
            _context.Produtos.FirstOrDefault
            (x => x.Categoria.Id.Equals(c.Id));

        public Produto VinculoFornecedor(Fornecedor f) =>
            _context.Produtos.FirstOrDefault
            (x => x.Fornecedor.Id.Equals(f.Id));
    }
}
