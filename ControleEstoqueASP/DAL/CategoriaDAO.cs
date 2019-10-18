using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.DAL
{
    public class CategoriaDAO
    {
        private readonly Context _context;
        public CategoriaDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void CadastrarCategoria(Categoria c)
        {
            _context.Categorias.Add(c);
            _context.SaveChanges();
        }

        public Categoria BuscarCategoriaPorNome
            (Categoria c) =>
            _context.Categorias.FirstOrDefault
            (x => x.Nome.Equals(c.Nome));

        public void AlterarCategoria(Categoria c)
        {
            Categoria atualizaRegistro = _context.Categorias.Where(x => x.Id == c.Id).FirstOrDefault();
            atualizaRegistro.Nome = c.Nome;
            atualizaRegistro.Descricao = c.Descricao;

            _context.Entry(atualizaRegistro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoverCategoria(Categoria c)
        {
            _context.Categorias.Remove(c);
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
