using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.DAL
{
    public class UsuarioDAO
    {
        private readonly Context _context;
        public UsuarioDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public Usuario BuscarUsuario(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x =>
                      x.Email.Equals(u.Email) &&
                      x.Senha.Equals(u.Senha));
        }

        public void CadastrarUsuario(Usuario u)
        {
            _context.Usuarios.Add(u);
            _context.SaveChanges();
        }

        public Usuario BuscarUsuarioPorNome
            (Usuario u) =>
            _context.Usuarios.FirstOrDefault
            (x => x.Nome.Equals(u.Nome));

        public Usuario BuscarUsuarioPorCpf
            (Usuario u) =>
            _context.Usuarios.FirstOrDefault
            (x => x.Cpf.Equals(u.Cpf));

        public void AlterarUsuario(Usuario u)
        {
            var atualizaRegistro = _context.Usuarios.Where(x => x.Id == u.Id).FirstOrDefault();
            atualizaRegistro.Nome = u.Nome;
            atualizaRegistro.Cpf = u.Cpf;
            atualizaRegistro.Sexo = u.Sexo;
            atualizaRegistro.DataNascimento = u.DataNascimento;
            atualizaRegistro.Cargo = u.Cargo;
            atualizaRegistro.Telefone = u.Telefone;
            atualizaRegistro.Email = u.Email;
            atualizaRegistro.Senha = u.Senha;

            _context.Entry(atualizaRegistro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoverUsuario(Usuario u)
        {
            _context.Usuarios.Remove(u);
            _context.SaveChanges();
        }
    }
}
