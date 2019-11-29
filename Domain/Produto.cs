using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do produto:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição do produto:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Categoria do produto:")]
        //[Required(ErrorMessage = "Campo Obrigatório!")]
        public Categoria Categoria { get; set; }

        [Display(Name = "Fornecedor do produto:")]
        //[Required(ErrorMessage = "Campo Obrigatório!")]
        public Fornecedor Fornecedor { get; set; }

        [Display(Name = "Preço do produto:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public double Preco { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
