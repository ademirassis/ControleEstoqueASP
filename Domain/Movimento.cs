using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Movimentos")]
    public class Movimento
    {
        public Movimento()
        {
            CriadoEm = DateTime.Now;
        }

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public string TipoMovimento { get; set; }
        public string EnderecoEstoque { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
