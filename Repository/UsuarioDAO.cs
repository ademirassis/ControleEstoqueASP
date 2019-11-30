using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioDAO
    {
        private readonly Context _context;
        public UsuarioDAO(Context context)
        {
            _context = context;
        }

        public Usuario BuscarUsuario(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x =>
                      x.Email.Equals(u.Email) &&
                      x.Senha.Equals(u.Senha));
        }

        public bool CadastrarUsuario(Usuario u)
        {
            if (BuscarUsuarioPorCpf(u) == null)
            {
                _context.Usuarios.Add(u);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario BuscarUsuarioPorNome
            (Usuario u) =>
            _context.Usuarios.FirstOrDefault
            (x => x.Nome.Equals(u.Nome));

        public Usuario BuscarUsuarioPorCpf
            (Usuario u) =>
            _context.Usuarios.FirstOrDefault
            (x => x.Cpf.Equals(u.Cpf));

        public bool AlterarUsuario(Usuario u)
        {
            var atualizaRegistro = _context.Usuarios.Where(x => x.Id == u.Id).FirstOrDefault();
            atualizaRegistro.Nome = u.Nome;
            atualizaRegistro.Cpf = u.Cpf;
            atualizaRegistro.Cargo = u.Cargo;
            atualizaRegistro.Email = u.Email;
            atualizaRegistro.Senha = u.Senha;

            _context.Entry(atualizaRegistro).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public Usuario BuscarUsuarioPorId(int? id)
        {
            return _context.Usuarios.Find(id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.Include(x => x.Endereco).ToList();
            // .Include("Enderecos").ToList();
        }

        public void RemoverUsuario(Usuario u)
        {
            _context.Usuarios.Remove(u);
            _context.SaveChanges();
        }
    }
}
