using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
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

        public Estoque BuscarEstoquePorProduto(int? produtoId)
        {
            Estoque e = _context.Estoque.
                Include(x => x.Produto).
                Include(x => x.Produto.Categoria).
                Include(x => x.Produto.Fornecedor).
                FirstOrDefault(x => x.Produto.Id == produtoId);
            return e;
        }

        public List<Estoque> ListarEnderecoEstoqueDisponivel()
        {
            return _context.Estoque.Include("Produto").Include("Produto.Categoria").Include("Produto.Fornecedor")
                .Where(x => x.Produto.Equals(null)).ToList();
        }

        public List<Estoque> ListarEstoquePorProduto()
        {
            return _context.Estoque.
                Include("Produto").
                Include("Produto.Categoria").
                Include("Produto.Fornecedor").
                Where(x => !x.Produto.Equals(null)).ToList();
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

            switch (m.TipoMovimento)
            {
                case "Entrada":
                    atualizaRegistro.Quantidade = m.Quantidade;
                    atualizaRegistro.Produto = m.Produto;
                    atualizaRegistro.AtualizadoEm = DateTime.Now;

                    _context.Entry(atualizaRegistro).State = EntityState.Modified;
                    _context.SaveChanges();
                    break;
                case "Saida":
                    atualizaRegistro.Quantidade = 0;
                    atualizaRegistro.Produto = null;
                    atualizaRegistro.AtualizadoEm = DateTime.Now;

                    _context.Entry(atualizaRegistro).State = EntityState.Modified;
                    _context.SaveChanges();
                    break;
                default:
                    break;
            }

        }
    }
}
