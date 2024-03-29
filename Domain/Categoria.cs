﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Descricao { get; set; }

        [Display(Name = "Criado em:")]
        public DateTime CriadoEm { get; set; }
    }
}
