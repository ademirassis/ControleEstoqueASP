using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.DAL
{
    public class FornecedorDAO
    {
        private readonly Context _context;
        public FornecedorDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void CadastrarFornecedor(Fornecedor c)
        {
            _context.Fornecedores.Add(c);
            _context.SaveChanges();
        }

        public Fornecedor BuscarFornecedorPorNome
            (Fornecedor c) =>
            _context.Fornecedores.FirstOrDefault
            (x => x.Nome.Equals(c.Nome));

        public void AlterarFornecedor(Fornecedor c)
        {
            Fornecedor atualizaRegistro = _context.Fornecedores.Where(x => x.Id == c.Id).FirstOrDefault();
            atualizaRegistro.Nome = c.Nome;
            atualizaRegistro.Cnpj = c.Cnpj;

            _context.Entry(atualizaRegistro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoverFornecedor(Fornecedor c)
        {
            _context.Fornecedores.Remove(c);
            _context.SaveChanges();
        }

        public List<Fornecedor> ListarFornecedores()
        {
            return _context.Fornecedores.ToList();
        }
    }
}
