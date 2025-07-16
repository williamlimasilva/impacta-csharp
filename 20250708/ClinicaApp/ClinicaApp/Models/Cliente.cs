using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "ID")]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nome do Cliente")]
        public string? Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Salário")]
        public double Salario { get; set; }
    }
}
