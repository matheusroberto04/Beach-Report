using System.ComponentModel.DataAnnotations;

namespace Beach_Report.DTOs
{
    public class ReportarDTO
    {
        [Required]
        public string DescricaoReportar { get; set; }
    }
}
