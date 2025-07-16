using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class Agendamento
    {
        [Key]
        public int AgendamentoId { get; set; }

        [StringLength(100)]
        public string? Cliente { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Especialidade")]
        public string Especialidade { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Médico")]
        public string Medico { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Data e Hora da Consulta")]
        public DateTime DataHoraConsulta { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tipo de Atendimento")]
        public string TipoAtendimento { get; set; } = string.Empty;
    }
}
