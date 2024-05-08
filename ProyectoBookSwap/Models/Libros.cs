﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoBookSwap.Models
{
    public class Libros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        

    }
}
