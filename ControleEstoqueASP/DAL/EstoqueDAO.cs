using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.DAL
{
    public class EstoqueDAO
    {
        private readonly Context _context;
        public EstoqueDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public Estoque BuscarEstoquePorId(int? id)
        {
            return _context.Estoque.Find(id);
        }

        public List<Estoque> ListarEnderecoEstoqueDisponivel()
        {
            return _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor")
                .Where(x => x.Produto.Equals(null)).ToList();
        }

        public List<Estoque> ListarEstoquePorProduto()
        {
            return _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor")
                      .Where(x => !x.Produto.Equals(null)).ToList();
        }

        public List<Estoque> ListarEnderecoEstoqueProduto(Movimento m)
        {
            return _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor")
                .Where(x => x.Produto.Id == m.Produto.Id && x.Quantidade == m.Quantidade).ToList();
        }

        public List<Estoque> ListarEnderecoEstoqueSituacao()
        {
            return _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor").ToList();
        }

        public void AtualizarEnderecoEstoque(Movimento m)
        {
            Estoque atualizaRegistro = _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor")
                .Where(x => x.Localizacao == m.EnderecoEstoque).FirstOrDefault();

            if (m.TipoMovimento == "Entrada")
            {
                atualizaRegistro.Quantidade = m.Quantidade;
                atualizaRegistro.Produto = m.Produto;
                atualizaRegistro.AtualizadoEm = DateTime.Now;

                _context.Entry(atualizaRegistro).State = EntityState.Modified;
                _context.SaveChanges();
            }
            else
            {
                atualizaRegistro.Quantidade = 0;
                atualizaRegistro.Produto = null;
                atualizaRegistro.AtualizadoEm = DateTime.Now;

                _context.Entry(atualizaRegistro).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
