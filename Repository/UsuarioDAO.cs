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

        public String BuscarCargoUsuario(String e)
        {
            Usuario u = _context.Usuarios.FirstOrDefault(x => x.Email.Equals(e));
            if (u != null)
            {
                return u.Cargo;
            }
            return null;
        }

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

        public bool ValidaCpf(String cpf)
        {
            if (cpf != null)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                cpf = cpf.Trim().Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;

                for (int j = 0; j < 10; j++)
                    if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                        return false;

                String tempCpf = cpf.Substring(0, 9);
                int soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                int resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                String digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cpf.EndsWith(digito);
            }
            return false;
        }
    }   
}
