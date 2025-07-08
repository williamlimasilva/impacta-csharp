using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public double Salario { get; set; }




    }
}
