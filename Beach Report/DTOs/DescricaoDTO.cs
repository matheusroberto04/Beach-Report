using System.ComponentModel.DataAnnotations;

namespace Beach_Report.DTOs
{
    
      public class DescricaoDTO
        {
            [Required]
            public string DescricoesReportar { get; set; }
            [Required]
            public int ReportarId { get; set; }
        }
}



