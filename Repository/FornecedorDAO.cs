using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class FornecedorDAO
    {
        private readonly Context _context;
        public FornecedorDAO(Context context)
        {
            _context = context;
        }

        public bool CadastrarFornecedor(Fornecedor f)
        {
            if (BuscarFornecedorPorNome(f) == null)
            {
                _context.Fornecedores.Add(f);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Fornecedor BuscarFornecedorPorNome(Fornecedor c) =>
            _context.Fornecedores.FirstOrDefault(x => x.Nome.Equals(c.Nome));

        public Fornecedor BuscarFornecedorPorId(int? id)
        {
            return _context.Fornecedores.Find(id);
        }

        public void AlterarFornecedor(Fornecedor f)
        {
            _context.Fornecedores.Update(f);
            _context.SaveChanges();
        }

        public void RemoverFornecedor(int? id)
        {
            _context.Fornecedores.Remove(BuscarFornecedorPorId(id));
            _context.SaveChanges();
        }

        public List<Fornecedor> ListarFornecedores()
        {
            return _context.Fornecedores.ToList();
        }
    }
}