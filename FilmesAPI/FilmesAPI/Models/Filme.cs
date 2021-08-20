﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Diretor { get; set; }

        public string Genero { get; set; }

        [Range(1, 600)]
        public int Duracao { get; set; }
    }
}
