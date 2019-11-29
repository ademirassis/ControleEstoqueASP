using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoriaDAO
    {
        private readonly Context _context;
        public CategoriaDAO(Context context)
        {
            _context = context;
        }

        public bool CadastrarCategoria(Categoria c)
        {
            if (BuscarCategoriaPorNome(c) == null)
            {
                _context.Categorias.Add(c);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Categoria BuscarCategoriaPorNome(Categoria c) 
            => _context.Categorias.FirstOrDefault
            (x => x.Nome.Equals(c.Nome));

        public void AlterarCategoria(Categoria c)
        {
            _context.Categorias.Update(c) ;
            _context.SaveChanges();
        }

        public Categoria BuscarCategoriaPorId(int? id)
        {
            return _context.Categorias.Find(id);
        }

        public void RemoverCategoria(int? id)
        {
            _context.Categorias.Remove(BuscarCategoriaPorId(id));
            _context.SaveChanges();
        }

        public List<Categoria> ListarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categoria ProdutoCategoria
         (int i) =>
         _context.Categorias.FirstOrDefault
         (x => x.Id.Equals(i));
    }
}
