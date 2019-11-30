using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now;
            Endereco Endereco = new Endereco();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cpf { get; set; }

        [Display(Name = "Cargo:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cargo { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Senha { get; set; }
        [NotMapped]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        public string ConfirmacaoSenha { get; set; }
        public Endereco Endereco { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
