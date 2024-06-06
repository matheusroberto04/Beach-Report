using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beach_Report.Models
{
    [Table("Tabela_De_Reportes")]
    public class Reportar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }
        [Required]
        [Column("Descricao_Relato")]
        public string DescricaoReportar { get; set;}
        [Required]
        [Column("Data_Da_Postagem")]
        public DateTime PostDate { get; set; }
        [Required]
        public ICollection<Descricao>? Descricaos { get; set; }
    }
}
