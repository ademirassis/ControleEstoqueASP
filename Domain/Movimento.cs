using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Nome do produto:")]
        public Produto Produto { get; set; }

        [Display(Name = "Categoria do produto:")]
        public Categoria Categoria { get; set; }

        [Display(Name = "Fornecedor do produto:")]
        public Fornecedor Fornecedor { get; set; }

        [Display(Name = "Quantidade do produto:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Quantidade { get; set; }

        [Display(Name = "Tipo de Movimento:")]
        public string TipoMovimento { get; set; }

        [Display(Name = "Endereço Estoque:")]
        public string EnderecoEstoque { get; set; }

        [Display(Name = "Criado em:")]
        public DateTime CriadoEm { get; set; }
    }
}
