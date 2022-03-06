﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Categorias")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
