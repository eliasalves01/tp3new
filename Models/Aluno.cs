using System;
using System.ComponentModel.DataAnnotations;

namespace InfnetWebApp.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Nome { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 10)]
        public string Endereco { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
