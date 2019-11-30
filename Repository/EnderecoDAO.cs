using System;
using Domain;

namespace Repository
{
    public class EnderecoDAO
    {
        private readonly Context _context;
        public EnderecoDAO(Context context)
        {
            _context = context;
        }

        public Endereco BuscarEnderecoPorId(int? id)
        {
            return _context.Enderecos.Find(id);
        }
    }
}