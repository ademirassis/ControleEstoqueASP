using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class MovimentoDAO
    {
        private readonly Context _context;
        public MovimentoDAO(Context context)
        {
            _context = context;
        }

        public void LancarMovimento(Movimento m)
        {
            _context.Movimentos.Add(m);
            _context.SaveChanges();
        }

        public List<Movimento> ListarMovimento()
        {
            return _context.Movimentos
                .Include("Produto").Include("Categoria").Include("Fornecedor")
                .ToList();
        }

        public List<Movimento> BuscarMovimentoPorTipoMovimento(String TipoMovimento)
        {
            return _context.Movimentos
                .Include("Produto").Include("Categoria").Include("Fornecedor")
                .Where(x => x.TipoMovimento.Equals(TipoMovimento)).ToList();
        }

        public Movimento BuscarMovimentoPorId(int id)
        {
            return _context.Movimentos
                .Include("Produto").Include("Categoria").Include("Fornecedor")
                .FirstOrDefault(x => x.Id.Equals(id));
        }

        public List<Movimento> BuscarMovimentoPorData(DateTime CriadoEm)
        {
            return _context.Movimentos
                .Include("Produto").Include("Categoria").Include("Fornecedor")
                .Where(x => x.CriadoEm.Day.Equals(CriadoEm.Day) &&
                            x.CriadoEm.Month.Equals(CriadoEm.Month) &&
                            x.CriadoEm.Year.Equals(CriadoEm.Year)).ToList();
        }

        public Movimento VinculoProduto(Produto p) => _context.Movimentos
            .FirstOrDefault(x => x.Produto.Id.Equals(p.Id));
    }
}
