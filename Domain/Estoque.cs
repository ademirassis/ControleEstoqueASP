using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Estoque")]
    public class Estoque
    {
        public Estoque()
        {
        }

        [Key]
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public string Localizacao { get; set; }
        public int Quantidade { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
