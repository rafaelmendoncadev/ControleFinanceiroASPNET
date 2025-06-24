﻿using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
