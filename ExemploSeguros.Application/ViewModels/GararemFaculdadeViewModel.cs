﻿using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class GararemFaculdadeViewModel
    {
        [Key]
        public int GaragemFaculdadeId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descrição")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
    }
}