using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonitoriaAgentes.Models
{
    public class Monitoria
    {
        public int MonitoriaId { get; set; }

        public string? Assunto { get; set; }


        //[DataType(DataType.Date)]

        [Required]
        [Display(Name = "Data da Monitoria")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataDaMonitoria { get; set; }


        //[Required(ErrorMessage = "O nome do agente é obrigatório", AllowEmptyStrings = false)]
        public string? NomeAgente { get; set; }

       // [Required(ErrorMessage = "Preenchimento obrigatório", AllowEmptyStrings = false)]
        public double? MatriculaAgente { get; set; }

      //  [Required(ErrorMessage = "Preenchimento obrigatório", AllowEmptyStrings = false)]
        public string? AD_Agente { get; set; }

        public string? NomeSupervisor { get; set; }

      //  [Required(ErrorMessage = "Preenchimento obrigatório", AllowEmptyStrings = false)]
        public string? Descricao { get; set; }
    }
}
