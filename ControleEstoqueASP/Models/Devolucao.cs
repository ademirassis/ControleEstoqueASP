using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueASP.Models
{
    [Table("Devolucoes")]
    public class Devolucao
    {
        public Devolucao()
        {
            CriadoEm = DateTime.Now;
        }

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
