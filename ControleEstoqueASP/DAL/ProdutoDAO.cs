using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.DAL
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public Produto BuscarProdutoPorNome
            (Produto p) =>
            _context.Produtos.FirstOrDefault
            (x => x.Nome.Equals(p.Nome));

        public void AlterarProduto(Produto p)
        {
            Produto atualizaRegistro = _context.Produtos.Where(x => x.Id == p.Id).FirstOrDefault();
            atualizaRegistro.Nome = p.Nome;
            atualizaRegistro.Descricao = p.Descricao;
            atualizaRegistro.Fornecedor = p.Fornecedor;
            atualizaRegistro.Preco = p.Preco;

            _context.Entry(atualizaRegistro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoverProduto(Produto p)
        {
            _context.Produtos.Remove(p);
            _context.SaveChanges();
        }

        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        public Produto VinculoCategoria
            (Categoria c) =>
            _context.Produtos.FirstOrDefault
            (x => x.Categoria.Id.Equals(c.Id));

        public Produto VinculoFornecedor
            (Fornecedor f) =>
            _context.Produtos.FirstOrDefault
            (x => x.Fornecedor.Id.Equals(f.Id));
    }
}
