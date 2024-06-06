using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beach_Report.Models
{
    [Table("Tabela_Descricao")]
    public class Descricao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }
        [Required]
        public int ReportarId { get; set; }
        public Reportar? Reportar { get; set; }
        [Required]
        [Column("Descricao_Do_Reporte")]
        public string DescricaoReportar { get; set;}
        [Required]
        [Column("Data_Do_Reporte")]
        public DateTime DataDescricao { get; set; }

    }
}
