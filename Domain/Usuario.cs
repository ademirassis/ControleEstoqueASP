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
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cpf { get; set; }

        [Display(Name = "Sexo:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Sexo { get; set; }

        [Display(Name = "Data Nascimento:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Cargo:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cargo { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Senha { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
